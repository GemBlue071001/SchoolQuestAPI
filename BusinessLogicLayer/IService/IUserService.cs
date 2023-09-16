using BusinessLogicLayer.RequestModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.IService
{
    public interface IUserService
    {
        public Task<string> LoginAsync(LoginRequest account);
        Task<bool> RegisterAsync(UserRegisterRequest user);
    }
}
