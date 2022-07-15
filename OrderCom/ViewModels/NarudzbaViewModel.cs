using CommunityToolkit.Mvvm.Input;
using OrderCom.Contracts;
using OrderCom.Models;
using OrderCom.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace OrderCom.ViewModels
{
    public partial class NarudzbaViewModel : BaseViewModel
    {
        private INarudzbaService _narudzbeniceService;
        public ObservableCollection<indkdat> Indkdat { get; set; } = new();


        public NarudzbaViewModel(INarudzbaService narudzbeniceService)
        {
            _narudzbeniceService = narudzbeniceService;

            Task.Run(async () => await LoadPageData());
        }

        private async Task LoadPageData()
        {
            IsBusy = true;
            var narudzbenice = await _narudzbeniceService.DajSveNarudzbenice();

            foreach (var narudzbenica in narudzbenice)
            {
                Indkdat.Add(narudzbenica);
            }
            IsBusy = false;
        }

        [RelayCommand]
        async Task DodajNaruzbuAsync()
        {
            IsBusy = true;
            await Task.Delay(2000);
        }

        [RelayCommand]
        async Task BrisiNarudzbuAsync(indkdat indkdat)
        {
            IsBusy = true;

            //TODO: Obrisati iz lokalne baze
            var indkToRemove = Indkdat.Where(indk => indk.in_brjdok == indkdat.in_brjdok);
            Indkdat.Remove(indkdat);

            IsBusy = false;
        }

        [RelayCommand]
        async Task GoToDetailsAsync(indkdat indkdat)
        {
            if (indkdat is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(NarudzbaDetailPage)}", true, new Dictionary<string, object>
            {
                { "Indkdat", indkdat }
            });
        }
    }
}
