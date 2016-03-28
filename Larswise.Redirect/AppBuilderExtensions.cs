using Owin;

namespace SslRedirectMiddleware
{
    public static class RedirectMiddlewareExtensions
    {
        public static IAppBuilder UseRedirectMiddleware(this IAppBuilder app, RedirectOptions options)
        {
            app.Use<HttpsRedirectMiddleware>(options);
            return app;
        }

        public static IAppBuilder UseRedirectMiddlewareDefaultSettings(this IAppBuilder app)
        {
            app.Use<HttpsRedirectMiddleware>(new RedirectOptions());
            return app;
        }
    }
}
