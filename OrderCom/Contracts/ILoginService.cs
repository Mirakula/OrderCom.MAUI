using OrderCom.DTOs;
using OrderCom.Models;

namespace OrderCom.Contracts
{
    public interface ILoginService
    {
        Task<Token> LoginAsync(LoginDTO loginData);
        void Logout();
    }
}
