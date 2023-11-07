using BusinessLogicLayer.ResponseModel.ApiResponse;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Net;

namespace HighSchoolQuestAPI.Middlewares
{
    public class GlobalMiddleware
    {
        private readonly RequestDelegate _next;

        private readonly ILogger<GlobalMiddleware> _logger;
        public GlobalMiddleware(RequestDelegate next, ILogger<GlobalMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                LogRequestDetails(context);
                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync("Somthing went wrong " + ex.Message);
                _logger.LogError("Somthing went wrong " + ex.Message);
            }
        }

        private void LogRequestDetails(HttpContext context)
        {
            var request = context.Request;

            // Log request method and path
            _logger.LogInformation($"Request: {request.Method} {request.Path}");

            // Log request headers
            foreach (var header in request.Headers)
            {
                _logger.LogInformation($"{header.Key}: {header.Value}");
            }

            // Log request query parameters
            var queryParameters = request.Query.Count > 0 ? string.Join(", ", request.Query.Select(q => $"{q.Key}={q.Value}")) : "None";
            _logger.LogInformation($"Query Parameters: {queryParameters}");

            // Log request body (if applicable)
            if (request.ContentLength > 0)
            {
                using (var reader = new StreamReader(request.Body))
                {
                    var requestBody = reader.ReadToEnd();
                    _logger.LogInformation($"Request Body: {requestBody}");
                }
            }
        }

    }
}
