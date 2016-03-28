
namespace SslRedirectMiddleware
{
    public class RedirectOptions
    {
        /// <summary>
        /// The SSL port to use, default is 443
        /// </summary>
        public int Port { get; set; } = 443;

        /// <summary>
        /// Set the redirect statuscode, default is 301
        /// Moved permanently. Others are 302 Found, 303 See Other, and others.
        /// </summary>
        public int StatusCode { get; set; } = 301;
    }
}
