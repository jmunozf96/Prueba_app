using System.Net;
using Domain.Exceptions;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Backend_Tolepu.Controllers
{
    [ApiExplorerSettings(IgnoreApi = true)]
    [ApiController]
    public class ErrorController : ControllerBase
    {
        [Route("/error")]
        public IActionResult Error(){
            var context = HttpContext.Features.Get<IExceptionHandlerFeature>();
            if(context.Error is ValidationException){
                var ex = (ValidationException) context.Error;
                return BadRequest(new {
                    title = context.Error?.Message,
                    errors = ex.Errors,
                    code = ex.Code
                });
            }
            if(context.Error is NotFoundException){
                return Problem(
                    statusCode: ((int)HttpStatusCode.NotFound),
                    title: context.Error?.Message
                );
            }
            return Problem(
                statusCode: ((int)HttpStatusCode.InternalServerError),
                title: context.Error?.Message,
                detail: context.Error?.StackTrace
            );
        }

    }
}