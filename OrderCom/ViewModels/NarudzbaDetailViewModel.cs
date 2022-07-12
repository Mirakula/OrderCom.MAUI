using CommunityToolkit.Mvvm.ComponentModel;
using OrderCom.Models;

namespace OrderCom.ViewModels
{
    [QueryProperty("indkdat", "indkdat")]

    public partial class NarudzbaDetailViewModel : BaseViewModel
    {
        [ObservableProperty]
        indkdat indkdat;
    }
}
