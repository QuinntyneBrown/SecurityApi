﻿
using System;
using Microsoft.Owin;
using Microsoft.Owin.Security.OAuth;
using SecurityApi.Config;
using SecurityApi.Services.Contracts;

namespace SecurityApi.Auth
{
    public class OAuthOptions : OAuthAuthorizationServerOptions
    {
        public OAuthOptions(SecurityApi.Services.Contracts.IIdentityService identityService)
        {
            var config = AppConfiguration.Config;

            TokenEndpointPath = new PathString(config.TokenPath);
            AccessTokenExpireTimeSpan = TimeSpan.FromMinutes(config.ExpirationMinutes);
            AccessTokenFormat = new JwtWriterFormat(this);
            Provider = new OAuthProvider(identityService);
            AllowInsecureHttp = true;
        }

    }
}
