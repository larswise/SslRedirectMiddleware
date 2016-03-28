using System;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace SslRedirectMiddleware
{
    public class HttpsRedirectMiddleware : OwinMiddleware
    {
        private RedirectOptions _options;
        public HttpsRedirectMiddleware(OwinMiddleware next, RedirectOptions options) : base(next)
        {
            _options = options;
        }

        public async override Task Invoke(IOwinContext context)
        {
            
            
            if (!context.Request.IsSecure)
            {
                var uriBuilder = new UriBuilder(context.Request.Uri);                
                uriBuilder.Port = _options.Port;
                uriBuilder.Scheme = "https";
                context.Response.StatusCode = _options.StatusCode;
                
                context.Response.Headers.Set("Location", uriBuilder.Uri.AbsoluteUri);
            }
            await Next.Invoke(context);
        }
        
    }
    

}
