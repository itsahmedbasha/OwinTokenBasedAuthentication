using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using TokenAuth.Providers;

[assembly: OwinStartup(typeof(TokenAuth.Startup))]
namespace TokenAuth
{
    public class Startup
    {

        public void Configuration(IAppBuilder app)
        {

           // HttpConfiguration config = new HttpConfiguration();

            ConfigureOAuth(app);
        }

        public void ConfigureOAuth(IAppBuilder app)
        {

            OAuthAuthorizationServerOptions oauthserveroptions = new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new Microsoft.Owin.PathString("/token"),
                //AccessTokenExpireTimeSpan = TimeSpan.from(2),
                Provider = new SimpleAuthorizationProvider()
            };

            app.UseOAuthAuthorizationServer(oauthserveroptions);
            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
        }


    }
}