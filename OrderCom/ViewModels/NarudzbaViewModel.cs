using CommunityToolkit.Mvvm.Input;
using OrderCom.Contracts;
using OrderCom.Models;
using OrderCom.Views;
using System.Collections.ObjectModel;

namespace OrderCom.ViewModels
{
    public partial class NarudzbaViewModel : BaseViewModel
    {
        private INarudzbeniceService _narudzbeniceService;
        public ObservableCollection<indkdat> Narudzbenice { get; set; } = new();


        public NarudzbaViewModel(INarudzbeniceService narudzbeniceService)
        {
            // TODO Dobaviti narudzbenice iz baze
            _narudzbeniceService = narudzbeniceService;

            var narudzbenice = Task.Run(async () => await _narudzbeniceService.DajSveNarudzbenice()).Result;

            foreach (var narudzbenica in narudzbenice)
            {
                Narudzbenice.Add(narudzbenica);
            }
        }

        [ICommand]
        async Task DodajNaruzbenicuAsync()
        {
            IsBusy = true;
            await Task.Delay(2000);
            Narudzbenice.Clear();
        }

        [ICommand]
        async Task GoToDetailsAsync(indkdat indkdat)
        {
            if (indkdat is null)
                return;

            await Shell.Current.GoToAsync($"{nameof(NarudzbaDetailPage)}", true, new Dictionary<string, object>
            {
                { "in_brjdok", indkdat }
            });
        }
    }
}
