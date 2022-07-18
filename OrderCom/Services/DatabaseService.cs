using OrderCom.Contracts;
using OrderCom.Models;
using SQLite;

namespace OrderCom.Services
{
    public class DatabaseService : IDatabaseService
    {
        private IHttpService _httpService;
        public DatabaseService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public SQLiteAsyncConnection db { get; set; }

        public async Task<bool> DeleteLocalDatabase()
        {
            await db.CloseAsync();

            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ORDC.db");

            if (File.Exists(databasePath))
            {
                File.Delete(databasePath);
                return true;
            }
            else
                return false;
        }

        public async Task DeployLocalDatabase()
        {
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "ORDC.db");
            db = new SQLiteAsyncConnection(databasePath);

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

        public async Task<bool> RefreshDatabase()
        {
            await db.DropTableAsync<akcpops>();

            IEnumerable<akcpops> akcpops = await _httpService.DajAkcijskePopuste();

            await db.InsertAllAsync(akcpops);

            return true;
        }
    }
}
