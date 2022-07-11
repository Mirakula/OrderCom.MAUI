using OrderCom.ViewModels;

namespace OrderCom.Views;

public partial class KnjiznaObavijestPage : ContentPage
{
	public KnjiznaObavijestPage(KnjiznaObavijestViewModel viewModel)
	{
		InitializeComponent();
        Shell.SetNavBarIsVisible(this, false);
        BindingContext = viewModel;
	}
}