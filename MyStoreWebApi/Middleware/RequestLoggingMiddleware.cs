namespace MyStoreWebApi.Middleware
{
    public class RequestLoggingMiddleware
    {

        private readonly RequestDelegate _next;
        public RequestLoggingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {

            //code before request goes to the next middleware
            Console.WriteLine($"Request:{context.Request.Method} {context.Request.Path}");

            await _next(context);

            //code after response come back 

            Console.WriteLine($"Response Status: {context.Response.StatusCode}");
        }
    }

    public static class RequestLoggingMiddlewareExtentions
    {

        public static IApplicationBuilder UseRequesrLogging(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<RequestLoggingMiddleware>();

        }
    }
}
