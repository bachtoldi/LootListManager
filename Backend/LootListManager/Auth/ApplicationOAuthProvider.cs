using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace LootListManager.Auth {
  public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider {

    private readonly string _publicClientId;

    public ApplicationOAuthProvider(string publicClientId) {
      if (publicClientId == null) {
        throw new ArgumentNullException("publicClientId");
      }

      _publicClientId = publicClientId;
    }

    public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context) {
      var userManager = context.OwinContext.GetUserManager<ApplicationUserManager>();

      context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });

      ApplicationUser user = await userManager.FindAsync(context.UserName, context.Password);

      if (user == null) {
        context.SetError("invalid_grant", "The username or password is incorrect.");
        return;
      }

      ClaimsIdentity oAuthIdentity = await user.GenerateUserIdentityAsync(userManager, OAuthDefaults.AuthenticationType);
      ClaimsIdentity cookiesIdentity = await user.GenerateUserIdentityAsync(userManager, CookieAuthenticationDefaults.AuthenticationType);

      AuthenticationProperties properties = CreateProperties(user.UserName);
      AuthenticationTicket ticket = new AuthenticationTicket(oAuthIdentity, properties);

      context.Validated(ticket);
      context.Request.Context.Authentication.SignIn(cookiesIdentity);

    }

    public override Task TokenEndpoint(OAuthTokenEndpointContext context) {
      foreach (var property in context.Properties.Dictionary) {
        context.AdditionalResponseParameters.Add(property.Key, property.Value);
      }

      return Task.FromResult<object>(null);
    }

    public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context) {
      //var clientId = string.Empty;
      //var clientSecret = string.Empty;

      //if (!context.TryGetBasicCredentials(out clientId, out clientSecret)) {
      //  context.TryGetFormCredentials(out clientId, out clientSecret);
      //}

      //if (context.ClientId == null) {
      //  context.SetError("invalid_clientId", "valid clientId is required");
      //  return;
      //}

      //if (clientSecret != "") {
      //  context.SetError("invalid_clientId", "valid clientId is required");
      //  return;
      //}

      //context.OwinContext.Set("as:clientAllowedOrigin", "*");
      //context.OwinContext.Set("as:clientRefreshTokenLifeTime", TimeSpan.FromMinutes(30).ToString());

      await Task.FromResult(context.Validated());
      return;
    }

    public override async Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context) {
      if (context.ClientId == _publicClientId) {
        var expectedRootUri = new Uri(context.Request.Uri, "/");

        if (expectedRootUri.AbsoluteUri == context.RedirectUri) {
          await Task.FromResult(context.Validated());
        }
      }

      return;
    }

    public override Task GrantRefreshToken(OAuthGrantRefreshTokenContext context) {
      var originalClient = context.Ticket.Properties.Dictionary["client_id"];
      var currentClient = context.ClientId;

      if (originalClient != currentClient) {
        context.Rejected();
        return Task.FromResult<object>(null);
      }

      var newIdentity = new ClaimsIdentity(context.Ticket.Identity);
      var roleId = context.Request.Query.Get("roleId");

      if (roleId != null) {
        if (newIdentity.Claims.Any(x => x.Type == "roleId")) {
          newIdentity.RemoveClaim(newIdentity.Claims.FirstOrDefault(x => x.Type == "roleId"));
        }

        newIdentity.AddClaim(new Claim("roleId", roleId));
      }

      var newTicket = new AuthenticationTicket(newIdentity, context.Ticket.Properties);
      context.Validated(newTicket);

      return Task.FromResult<object>(null);
    }

    public static AuthenticationProperties CreateProperties(string userName) {
      IDictionary<string, string> data = new Dictionary<string, string>();
      data.Add("userName", userName);
      return new AuthenticationProperties(data);
    }

  }
}