using AutoMapper;
using BusinessLogicLayer.DTO;
using BusinessLogicLayer.IService;
using BusinessLogicLayer.Properties;
using BusinessLogicLayer.RequestModel.User;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using BusinessLogicLayer.ResponseModel.User;
using DataAccessLayer.UnitOfWork;
using Domain.Enums;
using Domain.Global;
using Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;


namespace BusinessLogicLayer.Service
{
    public class UserService : IUserService
    {
        //private IConfiguration _configuration;
        private IUnitOfWork _unitOfWork;
        private AppSettings _appSettings;
        private IClaimsService _claimService;
        private IMapper _mapper;

        public UserService(IConfiguration configuration, IUnitOfWork unitOfWork, AppSettings appSettings, IMapper mapper, IClaimsService claimService)
        {
            //_configuration = configuration;
            _unitOfWork = unitOfWork;
            _appSettings = appSettings;
            _mapper = mapper;
            _claimService = claimService;
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

        public async Task<ApiResponse> RegisterAsync(UserRegisterRequest user)
        {
            ApiResponse response = new ApiResponse();

            var checkPassword = CheckUserPassword(user);
            if (!checkPassword)
            {
                response.SetBadRequest(message: Resources.ConfirmPasswordWrong);
                return response;
            }
            var pass = CreatePasswordHash(user.Password);
            User _user = new User()
            {
                UserName = user.UserName,
                PasswordHash = pass.PasswordHash,
                PasswordSalt = pass.PasswordSalt,
                Role = UserRole.Student,
                Email = user.Email,
                FirstName = user.FistName,
                LastName = user.LastName,
            };
            await _unitOfWork.Users.AddAsync(_user);
            await _unitOfWork.SaveChangeAsync();

            response.SetOk(Resources.ResgisterComplete);
            return response;
        }

        public async Task<ApiResponse> LoginAsync(LoginRequest account)
        {
            ApiResponse response = new ApiResponse();
            var _account = await _unitOfWork.Users.GetAsync(u => u.UserName == account.UserName);
            if (_account == null || !VerifyPasswordHash(account.Password, _account.PasswordHash, _account.PasswordSalt))
            {
                response.SetBadRequest(message: Resources.LoginFail);
                return response;
            }

            response.SetOk(CreateToken(_account));
            return response;
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
                new Claim(ClaimTypes.Role, user.Role.ToString()),
                new Claim("UserId", user.Id.ToString()),
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _appSettings!.SecretToken.Value));

            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: creds);

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }

        public async Task<ApiResponse> GetUserPagingAsync(int pageIndex, int pageSize, string search, bool isStudent)
        {
            ApiResponse apiResponse = new ApiResponse();
            var listOfUser = await _unitOfWork.Users.PagingAsync(pageIndex, pageSize, search , isStudent);
            var listOfUserResponse = _mapper.Map<List<UserResponse>>(listOfUser);
            var totalOfUser = await _unitOfWork.Users.CountPagingAsync(pageIndex, pageSize, search, isStudent);
            Pagination<UserResponse> response = new Pagination<UserResponse>(listOfUserResponse, totalOfUser, pageIndex, pageSize);

            apiResponse.SetOk(response);
            return apiResponse;
        }

        public async Task<ApiResponse> GetTotalOfUser()
        {
            var response = new ApiResponse();
            var totalNumOfExam = await _unitOfWork.Users.CountAsync();

            return response.SetOk(totalNumOfExam);
        }

        public async Task<ApiResponse> UpdateProfileAsync(UpdateProfileRequest userProfile)
        {
            var apiResponse = new ApiResponse();
            var userId = _claimService.GetUserIdInRequest();
            var user = await _unitOfWork.Users.GetAsync(x => x.Id == userId);

            _mapper.Map(userProfile, user);
            await _unitOfWork.SaveChangeAsync();

            return apiResponse.SetOk(Resources.UpdateSuccess);
        }


    }
}
