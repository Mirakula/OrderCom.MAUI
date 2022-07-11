using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OrderCom.Contracts;
using OrderCom.DTOs;
using OrderCom.Views;

namespace OrderCom.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        private ILoginService _loginService;
        public LoginViewModel(ILoginService loginService)
        {
            _loginService = loginService;
            Year = DateTime.Now.Year;
        }
        
        [ObservableProperty]
        int year;
        
        [ObservableProperty]
        string ca_sifrad;
        [ObservableProperty]
        string ca_imekrt;

        [ICommand]
        async Task LoginAsync()
        {
            IsBusy = true;
            LoginDTO loginData = new();
            loginData.ca_imekrt = Ca_imekrt;
            loginData.ca_sifrad = Convert.ToInt32(Ca_sifrad);

            var loginResult = await _loginService.LoginAsync(loginData);
            await SecureStorage.SetAsync("jwt_token", loginResult.JwtToken);

            await Shell.Current.GoToAsync("//Main");
        }
    }
}
