using OrderCom.Contracts;
using OrderCom.Models;
using OrderCom.Models.DTOs;
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

        public async Task LoginAsync(LoginDTO loginData)
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
                nakodat nakodat = new();
                nakodat = await response.Content.ReadFromJsonAsync<nakodat>();

                if (nakodat is not null)
                    await SecureStorage.SetAsync("nakodat", nakodat.ca_imekrt);
                else
                    await Shell.Current.DisplayAlert("Greška", "Pogrešno korisničko ime ili pasvord !", "OK");
            }
            else
            {
                await Shell.Current.DisplayAlert("Greška", "Intrena greška servera", "OK");
            }

        }

        public void Logout()
        {
            SecureStorage.Remove("jwt_token");
        }
    }
}
