using Owin;
using Microsoft.Owin.Security;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Owin.Security.Jwt;
using Microsoft.Owin.Host.SystemWeb;
using Microsoft.Owin;
using Backend.Entities;

[assembly: OwinStartup(typeof(API.Startup))]
namespace API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseJwtBearerAuthentication(
                new JwtBearerAuthenticationOptions
                {
                    AuthenticationMode = AuthenticationMode.Active,
                    TokenValidationParameters = new TokenValidationParameters()
                    {
                        ValidateIssuer = true,
                        ValidateAudience = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = "http://mysite.com", //some string, normally web url,  
                        ValidAudience = "http://mysite.com",
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(TokenManager.Secret))
                    }
                });
        }
    }
}