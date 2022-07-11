using CommunityToolkit.Mvvm.ComponentModel;

namespace OrderCom.ViewModels
{
    public partial class ProizvodViewModel : BaseViewModel
    {
        [ObservableProperty]
        string test = "PROI viewModel";
    }
}
