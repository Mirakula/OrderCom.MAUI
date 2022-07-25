using OrderCom.Models;
using OrderCom.Models.DTOs;

namespace OrderCom.Contracts
{
    public interface ILoginService
    {
        Task LoginAsync(LoginDTO loginData);
        void Logout();
    }
}
