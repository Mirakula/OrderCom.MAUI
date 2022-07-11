using OrderCom.ViewModels;

namespace OrderCom.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
		Shell.SetNavBarIsVisible(this, false);
    }
}