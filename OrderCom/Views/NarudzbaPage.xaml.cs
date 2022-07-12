using OrderCom.ViewModels;

namespace OrderCom.Views;

public partial class NarudzbaPage : ContentPage
{
	public NarudzbaPage(NarudzbaViewModel viewModel)
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
        BindingContext = viewModel;
	}
}