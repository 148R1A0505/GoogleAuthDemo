using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DotNetOpenAuth.GoogleOAuth2;
using Microsoft.AspNet.Membership.OpenAuth;



namespace GoogleAuthOwn
{
    public class AuthConfig
    {
        public static void RegisterAuth()
        {
            GoogleOAuth2Client clientGoog = new GoogleOAuth2Client("275657770228-6dele1ri26720stq9f99qpeqrlhuqkth.apps.googleusercontent.com", "Xrnnelu22SiA99grvsWJd7kD");
            IDictionary<string, string> extraData = new Dictionary<string, string>();
            OpenAuth.AuthenticationClients.Add("google", () => clientGoog, extraData);
        }
    }
}