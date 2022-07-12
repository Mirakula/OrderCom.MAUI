using CommunityToolkit.Mvvm.ComponentModel;
using OrderCom.Contracts;
using OrderCom.Models;
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
            //Instdat = Task.Run(async () => await _narudzbaService.DajStavkeNarudzbe(indkdat.in_brjdok)).Result;
            Debug.WriteLine(Indkdat);
        }

        [ObservableProperty]
        indkdat indkdat;

        [ObservableProperty]
        List<instdat> instdat;
    }
}
