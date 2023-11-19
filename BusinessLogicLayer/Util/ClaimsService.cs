using BusinessLogicLayer.IService;
using Microsoft.AspNetCore.Http;

namespace BusinessLogicLayer.Util
{
    public class ClaimsService : IClaimsService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ClaimsService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Guid GetUserIdInRequest()
        {
            var _tokenUserId = _httpContextAccessor.HttpContext.User.FindFirst("UserId");
            if (_tokenUserId == null) throw new ArgumentNullException("UserId can not be found!");
            var _userId = Guid.Parse(_tokenUserId?.Value.ToString()!);
            return _userId;
        }
    }
}
