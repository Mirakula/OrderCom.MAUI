using OrderCom.ViewModels;

namespace OrderCom.Views;

public partial class DokumentPage : ContentPage
{
	public DokumentPage(DokumentViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}