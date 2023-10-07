using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;

namespace ExpressWFA.Shared.Utility
{
    public static class AppSession
    {
        public static string AccessToken { get; set; }
        public static string RefreshToken { get; set; }

    }

}