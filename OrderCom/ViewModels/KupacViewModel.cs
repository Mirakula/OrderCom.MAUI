using CommunityToolkit.Mvvm.ComponentModel;

namespace OrderCom.ViewModels
{
    public partial class KupacViewModel : BaseViewModel
    {
        [ObservableProperty]
        string test = "KUP view model";
    }
}
