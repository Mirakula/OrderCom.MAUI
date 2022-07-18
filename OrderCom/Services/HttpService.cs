using OrderCom.Contracts;
using OrderCom.Models;
using OrderCom.Models.DTOs;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace OrderCom.Services
{
    public class HttpService : IHttpService
    {
        HttpClient _httpClient;

        public HttpService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<dajfins>> DajFinansije(dajfinsDTO dajfinsDTO)
        {
            var url = Api.BaseUrl + Api.DajFinasije;
            var response = new HttpResponseMessage();
            var json = JsonSerializer.Serialize<dajfinsDTO>(dajfinsDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await _httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<dajfins> dajfins = await response.Content.ReadFromJsonAsync<IEnumerable<dajfins>>();
                    return dajfins;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Greška, Akcijski popusti", $"Greška dobavljanja finansija \n {e.Message}", "OK");
                return null;
            }
        }

        public async Task<IEnumerable<dajgrpp>> DajGrupe(dajgrppDTO dajgrppDTO)
        {
            var url = Api.BaseUrl + Api.DajGrupe;
            var response = new HttpResponseMessage();
            var json = JsonSerializer.Serialize<dajgrppDTO>(dajgrppDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await _httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<dajgrpp> dajgrpp = await response.Content.ReadFromJsonAsync<IEnumerable<dajgrpp>>();
                    return dajgrpp;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Greška, Akcijski popusti", $"Greška dobavljanja grupa \n {e.Message}", "OK");
                return null;
            }
        }

        public async Task<IEnumerable<dajkupc>> DajKupce(dajkupcDTO dajkupcDTO)
        {
            var url = Api.BaseUrl + Api.DajKupce;
            var response = new HttpResponseMessage();
            var json = JsonSerializer.Serialize<dajkupcDTO>(dajkupcDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await _httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<dajkupc> dajkupc = await response.Content.ReadFromJsonAsync<IEnumerable<dajkupc>>();
                    return dajkupc;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Greška, Akcijski popusti", $"Greška dobavljanja kupaca \n {e.Message}", "OK");
                return null;
            }
        }

        public async Task<IEnumerable<dajlokc>> DajLokacije(dajlokcDTO dajlokcDTO)
        {
            var url = Api.BaseUrl + Api.DajLokacije;
            var response = new HttpResponseMessage();
            var json = JsonSerializer.Serialize<dajlokcDTO>(dajlokcDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await _httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<dajlokc> dajlokc = await response.Content.ReadFromJsonAsync<IEnumerable<dajlokc>>();
                    return dajlokc;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Greška, Akcijski popusti", $"Greška dobavljanja lokacija kupaca \n {e.Message}", "OK");
                return null;
            }
        }

        public async Task<IEnumerable<osnpops>> DajOsnovnePopuste(osnpopsDTO osnpopsDTO)
        {
            var url = Api.BaseUrl + Api.DajOsnovnePopuste;
            var response = new HttpResponseMessage();
            var json = JsonSerializer.Serialize<osnpopsDTO>(osnpopsDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await _httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<osnpops> osnpops = await response.Content.ReadFromJsonAsync<IEnumerable<osnpops>>();
                    return osnpops;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Greška, Akcijski popusti", $"Greška dobavljanja osnovnih popusta \n {e.Message}", "OK");
                return null;
            }
        }

        public async Task<IEnumerable<akcpops>> DajAkcijskePopuste()
        {
            var url = Api.BaseUrl + Api.DajAkcijskePopuste;
            var response = new HttpResponseMessage();
            try
            {
                response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<akcpops> akcpops = await response.Content.ReadFromJsonAsync<IEnumerable<akcpops>>();
                    return akcpops;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Greška, Akcijski popusti", $"Greška dobavljanja akcijskih popusta \n {e.Message}", "OK");
                return null;
            }
        }

        public async Task<IEnumerable<dajtipn>> DajPrograme(dajtipnDTO dajtipnDTO)
        {
            var url = Api.BaseUrl + Api.DajPrograme;
            var response = new HttpResponseMessage();
            var json = JsonSerializer.Serialize<dajtipnDTO>(dajtipnDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await _httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<dajtipn> dajtipn = await response.Content.ReadFromJsonAsync<IEnumerable<dajtipn>>();
                    return dajtipn;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Greška, Akcijski popusti", $"Greška dobavljanja prodajnih programa \n {e.Message}", "OK");
                return null;
            }
        }

        public async Task<IEnumerable<rokplac>> DajRokovePlacanja(rokplacDTO rokplacDTO)
        {
            var url = Api.BaseUrl + Api.DajRokovePlacanja;
            var response = new HttpResponseMessage();
            var json = JsonSerializer.Serialize<rokplacDTO>(rokplacDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await _httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    IEnumerable<rokplac> rokplac = await response.Content.ReadFromJsonAsync<IEnumerable<rokplac>>();
                    return rokplac;
                }
                else
                    return null;
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Greška, Akcijski popusti", $"Greška dobavljanja rokova placanja kupaca \n {e.Message}", "OK");
                return null;
            }
        }

        public async Task<int> DodajNarudzbu(indkdatDTO indkdatDTO)
        {
            var url = Api.BaseUrl + Api.DodajNarudzbu;
            var response = new HttpResponseMessage();
            var json = JsonSerializer.Serialize<indkdatDTO>(indkdatDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await _httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    int result = await response.Content.ReadFromJsonAsync<int>();
                    return result;
                }
                else
                    return -1;
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Greška, Akcijski popusti", $"Greška slanja narudzbe na server \n {e.Message}", "OK");
                return -1;
            }
        }

        public async Task<int> DodajStavkeNarudzbe(instdatDTO instdatDTO)
        {
            var url = Api.BaseUrl + Api.DodajStavkeNarudzbe;
            var response = new HttpResponseMessage();
            var json = JsonSerializer.Serialize<instdatDTO>(instdatDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await _httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    int result = await response.Content.ReadFromJsonAsync<int>();
                    return result;
                }
                else
                    return -1;
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Greška, Akcijski popusti", $"Greška stavki narudzbe na server \n {e.Message}", "OK");
                return -1;
            }
        }

        public async Task<int> ObrisiNarudzbu(brjdokDTO brjdokDTO)
        {
            var url = Api.BaseUrl + Api.BrisiNarudzbu;
            var response = new HttpResponseMessage();
            var json = JsonSerializer.Serialize<brjdokDTO>(brjdokDTO);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            try
            {
                response = await _httpClient.DeleteAsync(url+ $"?brjdok={brjdokDTO.brjdok}");

                if (response.IsSuccessStatusCode)
                {
                    int result = await response.Content.ReadFromJsonAsync<int>();
                    return result;
                }
                else
                    return -1;
            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Greška, Akcijski popusti", $"Greška brisanja narudzbe \n {e.Message}", "OK");
                return -1;
            }
        }
    }
}
