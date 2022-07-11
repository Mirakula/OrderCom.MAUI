using OrderCom.ViewModels;

namespace OrderCom.Views;

public partial class ProizvodPage : ContentPage
{
	public ProizvodPage(ProizvodViewModel viewModel)
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
        BindingContext = viewModel;
	}
}