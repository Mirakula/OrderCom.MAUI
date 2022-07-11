using CommunityToolkit.Mvvm.ComponentModel;
using OrderCom.Contracts;
using OrderCom.Models;
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

            var naruzbenice = Task.Run(async () => await _narudzbeniceService.DajSveNarudzbenice()).Result;

            foreach (var naruzbenica in naruzbenice)
            {
                Narudzbenice.Add(naruzbenica);
            }
        }



        [ObservableProperty]
        string test = "NAR viewModel";

    }
}
