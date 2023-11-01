using System;
using System.Net;
using System.Threading.Tasks;
using BusinessLogicLayer.ResponseModel.ApiResponse;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

public class PostgresExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<PostgresExceptionMiddleware> _logger;

    public PostgresExceptionMiddleware(RequestDelegate next, ILogger<PostgresExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (DbUpdateException ex)
        {
            // Check if the exception message indicates a foreign key violation
            if (ex.InnerException.Message.Contains("23503: insert or update on table") &&
                ex.InnerException.Message.Contains("violates foreign key constraint"))
            {
                // Handle the foreign key violation error
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Response.ContentType = "application/json";
                ApiResponse apiResponse = new ApiResponse().SetApiResponse(
                    statusCode: HttpStatusCode.InternalServerError,
                    isSuccess: false,
                    message: "Foreign key constraint violation: " + ex.Message + "\n The entity id you inserted with may be not in db "
                    );

                await context.Response.WriteAsync(JsonConvert.SerializeObject(apiResponse));
                _logger.LogError("Foreign key constraint violation: " + ex.Message);
            }
            else
            {
                // Handle other PostgreSQL exceptions as needed
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync("Database error: " + ex.Message);
                _logger.LogError("Database error: " + ex.Message);
            }
        }
    }
}
