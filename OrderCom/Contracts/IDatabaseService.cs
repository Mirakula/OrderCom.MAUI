using System.Threading.Tasks;

namespace OrderCom.Contracts
{
    public interface IDatabaseService
    {
        bool IsDbCreated();
        Task<bool> RefreshDatabase();
        Task DeployLocalDatabase();
        Task<bool> DeleteLocalDatabase();
    }
}
