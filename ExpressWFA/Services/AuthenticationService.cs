using ExpressWFA.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using ExpressWFA.Shared.Utility;
using System.Text;

namespace ExpressWFA.Services
{
    public class AuthenticationService
    {

        public async Task<bool> Login(LoginUserDTO request)
        {
            using (HttpClient client = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{DefaultConfig.APIBaseURL}/authentication/login", content);
                var jsonString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    var tokenResponse = JsonConvert.DeserializeObject<TokenDTO>(jsonString);

                    AppSession.AccessToken=tokenResponse.AccessToken;
                    AppSession.RefreshToken=tokenResponse.RefreshToken;
                    return true;
                }
                else
                {
                    ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(jsonString);
                    throw new Exception($"Error {errorResponse.StatusCode}: {errorResponse.Message}");
                }
            }
        }

    }
}