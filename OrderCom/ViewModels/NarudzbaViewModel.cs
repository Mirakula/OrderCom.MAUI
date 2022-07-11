using CommunityToolkit.Mvvm.ComponentModel;
using OrderCom.Models;
using System.Collections.ObjectModel;

namespace OrderCom.ViewModels
{
    public partial class NarudzbaViewModel : BaseViewModel
    {

        public NarudzbaViewModel()
        {

        }
        public ObservableCollection<indkdat> Narudzbenice { get; set; }

        [ObservableProperty]
        string test = "NAR viewModel";
    }
}
