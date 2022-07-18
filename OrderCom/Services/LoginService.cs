using OrderCom.Contracts;
using OrderCom.DTOs;
using OrderCom.Models;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace OrderCom.Services
{
    public class LoginService : ILoginService
    {
        HttpClient _httpClient;

        public LoginService()
        {
            _httpClient = new();
        }

        public async Task<Token> LoginAsync(LoginDTO loginData)
        {
            var url = Api.BaseUrl + Api.Login;
            var response = new HttpResponseMessage();
            var json = JsonSerializer.Serialize<LoginDTO>(loginData);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await _httpClient.PostAsync(url, content);
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Greška", $"{e.Message}" , "OK");
            }

            if (response.IsSuccessStatusCode)
            {
                Token token = new();
                token = await response.Content.ReadFromJsonAsync<Token>();

                if (token is not null)
                    return token;
                else
                    await Shell.Current.DisplayAlert("Greška", "Pogrešno korisničko ime ili pasvord !", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Greška", "Intrena greška servera", "OK");
                return null;
            }

            return null;
        }

        public void Logout()
        {
            SecureStorage.Remove("jwt_token");
        }
    }
}
