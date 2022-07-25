using OrderCom.Contracts;
using OrderCom.Models;
using OrderCom.Models.DTOs;
using SQLite;

namespace OrderCom.Services
{
    public class DatabaseService : IDatabaseService 
    {
        private IHttpService _httpService;
        public DatabaseService(IHttpService httpService)
        {
            _httpService = httpService;
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "ORDC.db");
            db = new SQLiteAsyncConnection(databasePath);
        }

        public SQLiteAsyncConnection db { get; set; }

        public async Task DeleteLocalDatabase()
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ORDC.db");

            if(File.Exists(databasePath))
                File.Delete(databasePath);
        }

        public async Task DeployLocalDatabase()
        {


            try
            {
                await db.CreateTableAsync<akcpops>();
                await db.CreateTableAsync<osnpops>();
                await db.CreateTableAsync<dajfins>();
                await db.CreateTableAsync<dajkupc>();
                await db.CreateTableAsync<dajlokc>();
                await db.CreateTableAsync<dajproi>();
                await db.CreateTableAsync<dajtipn>();
                await db.CreateTableAsync<rokplac>();
                await db.CreateTableAsync<webserv>();
                await db.CreateTableAsync<indkdat>();
                await db.CreateTableAsync<instdat>();
                await db.CreateTableAsync<dajgrpp>();

            }
            catch (Exception e)
            {
                await Shell.Current.DisplayAlert("Greška, Baza podataka", "Baza podataka se ne može kreirati. Pozovite održavanje !", "OK"!);
                await Shell.Current.DisplayAlert($"Greška, Baza podataka", $"{e.Message}", "OK"!);
            }
        }



        public bool IsDbCreated()
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ORDC.db");

            if (File.Exists(databasePath))
                return true;
            else
                return false;
        }

        public async Task<IEnumerable<akcpops>> OsvjeziAkcijskePopuste()
        {
            var result = await _httpService.DajAkcijskePopuste();
            await db.DeleteAllAsync<akcpops>();
            await db.InsertAllAsync(result);
            
            return result;
        }

        public async Task<IEnumerable<namadat>> OsvjeziProizvode(dajproiDTO dajproiDTO)
        {
            var result = await _httpService.DajProizvode(dajproiDTO);

            await db.DropTableAsync<namadat>();
            await db.InsertAllAsync(result);

            return result;
        }

        public async Task<IEnumerable<dajtipn>> OsvjeziPrograme(dajtipnDTO dajtipnDTO)
        {
            var result = await _httpService.DajPrograme(dajtipnDTO);

            await db.DropTableAsync<dajtipn>();
            await db.InsertAllAsync(result);

            return result;
        }

        public  async Task<IEnumerable<dajkupc>> OsvjeziKupce(dajkupcDTO dajkupcDTO)
        {
            var result = await _httpService.DajKupce(dajkupcDTO);

            await db.DropTableAsync<dajkupc>();
            await db.InsertAllAsync(result);

            return result;
        }
    }
}
