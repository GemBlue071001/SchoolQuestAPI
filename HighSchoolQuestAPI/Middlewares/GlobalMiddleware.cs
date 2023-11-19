using BusinessLogicLayer.ResponseModel.ApiResponse;
using Newtonsoft.Json;

namespace BlueShopAPI.Middlewares
{
    public class GlobalMiddleware : IMiddleware
    {
        private readonly ILogger<GlobalMiddleware> _logger;

        public GlobalMiddleware(ILogger<GlobalMiddleware> logger)
        {
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unhandled exception occurred.");
                var response = new ApiResponse();
                await WriteResponseAsync(context, response.SetApiResponse(
                    statusCode: System.Net.HttpStatusCode.InternalServerError, 
                    isSuccess:false,
                    message: ex.Message, 
                    result: null));
            }
        }

        private static async Task WriteResponseAsync(HttpContext context, ApiResponse response)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = (int)response.StatusCode;
            await context.Response.WriteAsync(JsonConvert.SerializeObject(response));
        }
    }
}
