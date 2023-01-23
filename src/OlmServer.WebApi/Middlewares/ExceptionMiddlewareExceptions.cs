namespace OlmServer.WebApi.Middlewares
{
    public static class ExceptionMiddlewareExceptions
    {
        public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
