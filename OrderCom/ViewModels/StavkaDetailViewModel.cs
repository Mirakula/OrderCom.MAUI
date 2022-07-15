using CommunityToolkit.Mvvm.ComponentModel;
using OrderCom.Models;

namespace OrderCom.ViewModels
{
    [QueryProperty("Instdat", "Instdat")]
    public partial class StavkaDetailViewModel : BaseViewModel
    {
        public StavkaDetailViewModel()
        {

        }

        partial void OnInstdatChanged(instdat instdat)
        {
            Task.Run(async () => await LoadPageData(instdat));
        }

        private async Task LoadPageData(instdat instdat)
        {
            IsBusy = true;

            if (instdat is not null)
                IsBusy = false;
        }

        [ObservableProperty]
        instdat instdat;
    }
}
