using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace P620231_API.Attributes
{
    [AttributeUsage(validOn:AttributeTargets.All)]
    public sealed class ApiKeyAttribute : Attribute, IAsyncActionFilter
    {
        //Aqui ponemos la funcionalidad para la decoracion  de apikey que 
        //usaremos mas adelante esto para limitar y dar seguridad para un end point

        private readonly string _apiKey = "P6ApiKey";

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //Valida si el header del request va la infromacion del apikey

            if (!context.HttpContext.Request.Headers.TryGetValue(_apiKey, out var ApiSalida))
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "Api Key no dada!"
                };
                return;
            }

            var appSettings = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>();

            var ApiKeyValue = appSettings.GetValue<string>(_apiKey);

            if (!ApiKeyValue.Equals(ApiSalida)) 
            {
                context.Result = new ContentResult()
                {
                    StatusCode = 401,
                    Content = "La llave de seguridad dada es inconrrecta"
                };
                return;
            }

            await next();      
        }
    
    
    
    
    }
}
