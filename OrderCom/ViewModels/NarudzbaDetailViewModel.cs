using CommunityToolkit.Mvvm.ComponentModel;
using OrderCom.Contracts;
using OrderCom.Models;
using System.ComponentModel;
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

        partial void OnIndkdatChanged(indkdat indkdat)
        {
            Instdat = _narudzbaService.DajStavkeNarudzbe(indkdat.in_brjdok);
        }

        [ObservableProperty]
        indkdat indkdat;

        [ObservableProperty]
        List<instdat> instdat;

        [ObservableProperty]
        namadat namadat;
    }
}
