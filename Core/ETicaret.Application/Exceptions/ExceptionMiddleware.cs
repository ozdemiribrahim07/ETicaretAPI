using Microsoft.AspNetCore.Http;
using SendGrid.Helpers.Errors.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Exceptions
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




		private static Task HandleExceptionAsync(HttpContext context, Exception exception)
		{

			int statusCode = GetStatus(exception);
			context.Response.ContentType = "application/json";
			context.Response.StatusCode = statusCode;

			List<string> errors = new()
			{
				exception.Message,
				exception.InnerException?.ToString()
			};

			return context.Response.WriteAsync(new ExceptionModel
			{
				Errors = errors,
				StatusCode = statusCode
			}.ToString());

		}




		private static int GetStatus(Exception exception) => 
		
			exception switch
			{
				BadRequestException => StatusCodes.Status400BadRequest,
				NotFoundException => StatusCodes.Status404NotFound,
				ValidationException => StatusCodes.Status422UnprocessableEntity,
				 _ => StatusCodes.Status500InternalServerError
			};
		



    }
}
