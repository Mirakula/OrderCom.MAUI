using OrderCom.Contracts;
using OrderCom.Models;
using SQLite;

namespace OrderCom.Services
{
    public class DatabaseService : IDatabaseService
    {
        public DatabaseService()
        {
        }
        public SQLiteAsyncConnection db { get; set; }
        public async Task Init()
        {
            if (db != null)
                return;

            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ORDC.db");
            db = new SQLiteAsyncConnection(databasePath);
            await DeployLocalDatabase();

        }


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
            try
            {
                await db.CreateTableAsync<akcpops>();
                await db.CreateTableAsync<dajfins>();
                await db.CreateTableAsync<dajkupc>();
                await db.CreateTableAsync<dajlokc>();
                await db.CreateTableAsync<dajproi>();
                await db.CreateTableAsync<dajtipn>();
                await db.CreateTableAsync<rokplac>();
                await db.CreateTableAsync<webserv>();
            }
            catch (Exception ex)
            {

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

        public Task<bool> RefreshDatabase()
        {
            throw new System.NotImplementedException();
        }
    }
}
