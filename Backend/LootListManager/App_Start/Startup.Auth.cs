using LootListManager.Auth;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using Owin;
using System;

namespace LootListManager {
  public partial class Startup {

    public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }
    public static string PublicClientId { get; private set; }

    public void ConfigureAuth(IAppBuilder app) {

      app.CreatePerOwinContext<ApplicationUserManager>(ApplicationUserManager.Create);
      app.CreatePerOwinContext<ApplicationRoleManager>(ApplicationRoleManager.Create);

      app.UseCookieAuthentication(new CookieAuthenticationOptions());
      app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalCookie);

      PublicClientId = "self";
      OAuthOptions = new OAuthAuthorizationServerOptions {
        TokenEndpointPath = new PathString("/Auth/Token"),
        Provider = new ApplicationOAuthProvider(PublicClientId),
        AuthorizeEndpointPath = new PathString("/Auth/ExternalLogin"),
        AccessTokenExpireTimeSpan = TimeSpan.FromDays(14),
        AllowInsecureHttp = true
      };

      app.UseOAuthBearerTokens(OAuthOptions);
    }
  }
}