using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OrderCom.Contracts;
using OrderCom.DTOs;

namespace OrderCom.ViewModels
{
    public partial class LoginViewModel : BaseViewModel
    {
        private ILoginService _loginService;
        private IDatabaseService _databaseService;
        public LoginViewModel(ILoginService loginService, IDatabaseService databaseService)
        {
            _loginService = loginService;
            _databaseService = databaseService;

            Year = DateTime.Now.Year;

            Task.Run(async () => await InitLocalDatabase());
        }

        [ObservableProperty]
        int year;
        
        [ObservableProperty]
        string ca_sifrad;
        [ObservableProperty]
        string ca_imekrt;

        private async Task InitLocalDatabase()
        {
            bool isCreated = _databaseService.IsDbCreated();

            if (!isCreated)
                await _databaseService.DeployLocalDatabase();
        }

        [RelayCommand]
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
