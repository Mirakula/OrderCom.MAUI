using OrderCom.ViewModels;

namespace OrderCom.Views;

public partial class NarudzbaDetailPage : ContentPage
{
	public NarudzbaDetailPage(NarudzbaDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}