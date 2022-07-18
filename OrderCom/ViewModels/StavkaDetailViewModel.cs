using CommunityToolkit.Mvvm.ComponentModel;
using OrderCom.Models;

namespace OrderCom.ViewModels
{
    [QueryProperty("Namadat", "Namadat")]
    public partial class StavkaDetailViewModel : BaseViewModel
    {
        public StavkaDetailViewModel()
        {

        }

        partial void OnNamadatChanged(namadat namadat)
        {
            Task.Run(async () => await LoadPageData(namadat));
        }

        private async Task LoadPageData(namadat namadat)
        {
            IsBusy = true;

            if (namadat is not null)
                IsBusy = false;
        }

        [ObservableProperty]
        namadat namadat;
    }
}
