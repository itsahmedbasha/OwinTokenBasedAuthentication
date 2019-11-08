using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.Security.Claims;

namespace TokenAuth.Providers
{
    public class SimpleAuthorizationProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            if (context.UserName == "basha@gmail.com" && context.Password == "admin")
            {
                var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "Username and password invalid");
            }


        }
    }
}