using OrderCom.ViewModels;

namespace OrderCom.Views;

public partial class StavkaDetailPage : ContentPage
{
	public StavkaDetailPage(StavkaDetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}