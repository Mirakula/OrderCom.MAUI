using OrderCom.ViewModels;
using System.Diagnostics;

namespace OrderCom.Views;

public partial class NarudzbaDetailPage : ContentPage
{
	public NarudzbaDetailPage(NarudzbaDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}