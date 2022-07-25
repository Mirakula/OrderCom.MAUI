using CommunityToolkit.Mvvm.Input;
using OrderCom.Contracts;
using OrderCom.Models;
using OrderCom.Models.DTOs;
using OrderCom.Views;
using System.Collections.ObjectModel;

namespace OrderCom.ViewModels
{
    public partial class NarudzbaViewModel : BaseViewModel
    {
        private INarudzbaService _narudzbeniceService;
        private IDatabaseService _databaseService;
        private IHttpService _httpService;
        public ObservableCollection<indkdat> Indkdat { get; set; } = new();


        public NarudzbaViewModel(INarudzbaService narudzbeniceService,
                                 IDatabaseService databaseService,
                                 IHttpService httpService)
        {
            _narudzbeniceService = narudzbeniceService;
            _databaseService = databaseService;

            Task.Run(async () => await _databaseService.DeleteLocalDatabase());
            Task.Run(async () => await _databaseService.DeployLocalDatabase());
            Task.Run(async () => await OsvjeziBazuPodataka());
            Task.Run(async () => await LoadPageData());
            _httpService = httpService;
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

        private async Task OsvjeziBazuPodataka()
        {
            string ca_imekrt = await SecureStorage.GetAsync("nakodat");

            var result = await _httpService.DajPrograme(new dajtipnDTO { ca_imekrt = ca_imekrt });
            await _databaseService.OsvjeziAkcijskePopuste();
            //await _databaseService.OsvjeziProizvode();
        }

        [RelayCommand]
        async Task DodajNaruzbuAsync()
        {
            await Shell.Current.GoToAsync($"{nameof(DokumentPage)}", true);
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
