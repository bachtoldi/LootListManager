﻿using Microsoft.Owin.Security.OAuth;
using Owin;

namespace LootListManager {
  public partial class Startup {
    public static OAuthAuthorizationServerOptions OAuthOptions { get; private set; }
    public static string PublicClientId { get; private set; }

    public void ConfigureAuth(IAppBuilder app) {

    }
  }
}