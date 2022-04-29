﻿using Authgear.Xamarin.Oauth;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Authgear.Xamarin.Data
{
    internal interface IOauthRepo
    {
        string Endpoint { get; set; }
        Task<OidcConfiguration> OidcConfiguration();
        Task<OidcTokenResponse> OidcTokenRequest(OidcTokenRequest request);
        void BiometricSetupRequest(string accessToken, string clientId, string jwt);
        void OidcRevocationRequest(string refreshToken);
        Task<UserInfo> OidcUserInfoRequest(string accessToken);
        ChallengeResponse OauthChallenge(string purpose);
        AppSessionTokenResponse OauthAppSessionToken(string refreshToken);
        void WechatAuthCallback(string code, string state);
    }
}
