using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using ExpressWFA.Models;
using ExpressWFA.Shared.Utility;
using System.Text;
using System.Windows.Forms;

namespace ExpressWFA.Services
{
    public class UserService
    {
        public async Task<IEnumerable<GetUsersListDTO>> GetUsers()
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppSession.AccessToken);

                var response = await client.GetAsync($"{DefaultConfig.APIBaseURL}/user/list");
                var jsonString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<IEnumerable<GetUsersListDTO>>(jsonString);
                }
                else
                {
                    ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(jsonString);
                    throw new Exception($"Error {errorResponse.StatusCode}: {errorResponse.Message}");
                }
            }
        }


        public async Task CreateUser(CreateUserDTO request)
        {

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppSession.AccessToken);

                var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                var response = await client.PostAsync($"{DefaultConfig.APIBaseURL}/user", content);
                var jsonString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                 //   var tokenResponse = JsonConvert.DeserializeObject<TokenDTO>(jsonString);
                    return;
                }
                else
                {
                    ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(jsonString);
                    throw new Exception($"Error {errorResponse.StatusCode}: {errorResponse.Message}");
                }
            }
        }


        public async Task<UserDetailsDTO> GetUserDetails(int userId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppSession.AccessToken);

                var response = await client.GetAsync($"{DefaultConfig.APIBaseURL}/user/{userId}");
                var jsonString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<UserDetailsDTO>(jsonString);
                }
                else
                {
                    ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(jsonString);
                    throw new Exception($"Error {errorResponse.StatusCode}: {errorResponse.Message}");
                }
            }
        }


        public async Task<bool> UpdateUser(int userId,UpdateUserDTO request)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppSession.AccessToken);

                var content = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                var response = await client.PutAsync($"{DefaultConfig.APIBaseURL}/user/{userId}", content);
                var jsonString = await response.Content.ReadAsStringAsync();
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(jsonString);
                    throw new Exception($"Error {errorResponse.StatusCode}: {errorResponse.Message}");
                }
            }
        }


        public async Task<bool> DeleteUser(int userId)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppSession.AccessToken);

                var response = await client.DeleteAsync($"{DefaultConfig.APIBaseURL}/user/{userId}");
                var jsonString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(jsonString);
                    throw new Exception($"Error {errorResponse.StatusCode}: {errorResponse.Message}");
                }
            }
        }

        public async Task<IEnumerable<GetUsersListDTO>> GetUserByPattern(string searchPattern)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", AppSession.AccessToken);

                var response = await client.GetAsync($"{DefaultConfig.APIBaseURL}/user/pattern/{searchPattern}");
                var jsonString = await response.Content.ReadAsStringAsync();

                if (response.IsSuccessStatusCode)
                {
                    return JsonConvert.DeserializeObject<IEnumerable<GetUsersListDTO>>(jsonString);
                }
                else
                {
                    ErrorResponse errorResponse = JsonConvert.DeserializeObject<ErrorResponse>(jsonString);
                    throw new Exception($"Error {errorResponse.StatusCode}: {errorResponse.Message}");
                }
            }
        }

        #region private



        #endregion
    }
}