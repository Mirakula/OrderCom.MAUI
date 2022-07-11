using CommunityToolkit.Mvvm.ComponentModel;

namespace OrderCom.ViewModels
{
    public partial class NarudzbaViewModel : BaseViewModel
    {
        [ObservableProperty]
        string test = "NAR viewModel";
    }
}
