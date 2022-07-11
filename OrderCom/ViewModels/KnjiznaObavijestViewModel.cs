using CommunityToolkit.Mvvm.ComponentModel;

namespace OrderCom.ViewModels
{
    public partial class KnjiznaObavijestViewModel : BaseViewModel
    {
        [ObservableProperty]
        string test = "KNJO. ViewModel Test";
    }
}
