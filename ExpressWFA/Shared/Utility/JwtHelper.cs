using System.IdentityModel.Tokens.Jwt;
using System.Linq;

namespace ExpressWFA.Shared.Utility
{
    public class JwtHelper
    {
        public static string GetClaim(string claimType)
        {
            var jwtToken = new JwtSecurityToken(AppSession.AccessToken);
            var claim = jwtToken.Claims.FirstOrDefault(c => c.Type == claimType);
            return claim?.Value;
        }
    }
}