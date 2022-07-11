using OrderCom.ViewModels;

namespace OrderCom.Views;

public partial class KupacPage : ContentPage
{
	public KupacPage(KupacViewModel viewModel)
	{
		InitializeComponent();
		Shell.SetNavBarIsVisible(this, false);
        BindingContext = viewModel;
	}
}