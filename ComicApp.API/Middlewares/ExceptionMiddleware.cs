
using ComicApp.Contracts.Common;
using FluentValidation;
using System.Text.Json;

namespace ComicApp.API.Middlewares
{
    public class ExceptionMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
			try
			{
				await next(context);
			}
			catch (Exception e)
			{
				await HandleExceptionAsync(context, e);
			}
        }

		private async Task HandleExceptionAsync(HttpContext context, Exception e)
		{
			TaskResultDTO result = new TaskResultDTO()
			{
				Success = false
			};

			if (e is ValidationException)
			{
				result.Errors = ((ValidationException)e).Errors.Select(error => error.ErrorMessage).ToList();
			}
			else
			{
				result.Errors = new List<string>() { e.StackTrace };
			}

			context.Response.ContentType = "application/json";

			context.Response.StatusCode = 400;

			await context.Response.WriteAsync(JsonSerializer.Serialize(result));
		}
    }
}
