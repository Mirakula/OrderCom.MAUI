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
        public ObservableCollection<indkdat> Narudzbenice { get; set; } = new();


        public NarudzbaViewModel(INarudzbaService narudzbeniceService)
        {
            // TODO Dobaviti narudzbenice iz baze
            _narudzbeniceService = narudzbeniceService;

            var narudzbenice = Task.Run(async () => await _narudzbeniceService.DajSveNarudzbenice()).Result;

            foreach (var narudzbenica in narudzbenice)
            {
                Narudzbenice.Add(narudzbenica);
            }
        }

        [RelayCommand]
        async Task DodajNaruzbenicuAsync()
        {
            IsBusy = true;
            await Task.Delay(2000);
            Narudzbenice.Clear();
        }

        [RelayCommand]
        async Task OnSwipeDeleteAsync(indkdat nakodat)
        {
            Debug.WriteLine("Swiped");
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
