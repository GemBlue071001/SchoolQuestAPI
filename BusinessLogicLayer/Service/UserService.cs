using BusinessLogicLayer.IService;
using BusinessLogicLayer.RequestModel;
using DataAccessLayer.UnitOfWork;
using Domain.Enums;
using Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;


namespace BusinessLogicLayer.Service
{
    public class UserService : IUserService
    {
        private IConfiguration _configuration;
        private IUnitOfWork _unitOfWork;
        public UserService(IConfiguration configuration, IUnitOfWork unitOfWork)
        {
            _configuration = configuration;
            _unitOfWork = unitOfWork;
        }

        private PasswordDTO CreatePasswordHash(string password)
        {
            PasswordDTO pass = new PasswordDTO();
            using (var hmac = new HMACSHA512())
            {
                pass.PasswordSalt = hmac.Key;
                pass.PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
            return pass;
        }

        public bool CheckUserPassword(UserRegisterRequest user)
        {
            if (user.Password is null) return (false);
            return (user.Password.Equals(user.ConfirmPassword));
        }

        public async Task<bool> RegisterAsync(UserRegisterRequest user)
        {
            var checkPassword = CheckUserPassword(user);
            if (!checkPassword) return false;
            var pass = CreatePasswordHash(user.Password);
            User _user = new User()
            {
                UserName = user.UserName,
                PasswordHash = pass.PasswordHash,
                PasswordSalt = pass.PasswordSalt,
                Role = UserRole.Student
            };
            await _unitOfWork.Users.AddAsync(_user);
            await _unitOfWork.SaveChangeAsync();
            return true;
        }

        public async Task<string> LoginAsync(LoginRequest account)
        {
            var _account = await _unitOfWork.Users.GetAsync(u => u.UserName == account.UserName);
            if (_account == null && !VerifyPasswordHash(account.Password, _account.PasswordHash, _account.PasswordSalt))
                return null;
            return CreateToken(_account);
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim( "name" , user.UserName),
                new Claim("Role", user.Role.ToString()),
                new Claim("UserId", user.Id.ToString()),
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

    }
}
