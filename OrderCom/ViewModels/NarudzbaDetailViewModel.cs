using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OrderCom.Contracts;
using OrderCom.Models;
using OrderCom.Views;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace OrderCom.ViewModels
{
    [QueryProperty("Indkdat", "Indkdat")]

    public partial class NarudzbaDetailViewModel : BaseViewModel
    {
        private INarudzbaService _narudzbaService;
        public NarudzbaDetailViewModel(INarudzbaService narudzbaService)
        {
            _narudzbaService = narudzbaService;
        }

        public List<namadat> Namadat = new();
        public ObservableCollection<instdat> Instdat { get; set; } = new();


        partial void OnIndkdatChanged(indkdat indkdat)
        {
            Task.Run(async () => await LoadPageData(indkdat));
        }

        private async Task LoadPageData(indkdat indkdat)
        {
            IsBusy = true;
            var stavke = _narudzbaService.DajStavkeNarudzbe(indkdat.in_brjdok).ToList();

            var neb = await _narudzbaService.DajSveNarudzbenice();

            foreach (var stavka in stavke)
            {
                Instdat.Add(stavka);
            }

            List<namadat> __namadat = new();

            foreach (var instdat in Instdat)
            {
                Namadat.Add(_narudzbaService.DajProizvod(instdat.kn_sifmat).Result);
            }

            foreach (var instdat in Instdat)
            {
                foreach (var namadat in Namadat)
                {
                    if (instdat.kn_sifmat == namadat.ea_sifmat)
                        instdat.kn_nazrob = namadat.ea_imemat;
                }
            }
            IsBusy = false;
        }

        [RelayCommand]
        async Task BrisiStavkuAsync(instdat instdat)
        {
            IsBusy = true;
            if (instdat is null)
                return;

            var instToRemove = Instdat.Where(inst => inst.kn_redbrj == instdat.kn_redbrj).FirstOrDefault();

            if (instToRemove is not null)
            {
                Instdat.Remove(instToRemove);
            }
            else
                await Shell.Current.DisplayAlert("Brisanje stavke", "Stavka je već obrisana", "OK");
            IsBusy = false;
        }

        [RelayCommand]
        async Task GoToStavkeDetailsAsync(instdat instdat)
        {
            if (instdat is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(StavkaDetailPage)}", true, new Dictionary<string, object>
            {
                { "Instdat", instdat}
            });
        }

        [ObservableProperty]
        indkdat indkdat;

        //[ObservableProperty]
        //List<instdat> instdat;
    }
}
