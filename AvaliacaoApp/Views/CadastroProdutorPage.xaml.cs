using AvaliacaoApp.ViewModels;

namespace AvaliacaoApp.Views;

public partial class CadastroProdutorPage : ContentPage
{
	

    public CadastroProdutorPage(CadastroProdutorModel vm)
	{
		InitializeComponent();
		
		BindingContext = vm;
	}
}