using AvaliacaoApp.Models;
using AvaliacaoApp.ViewModels;

namespace AvaliacaoApp.Views;

public partial class ListarProdutorPage : ContentPage
{
	public ListarProdutorPage(CadastroProdutorModel vm)
	{
		InitializeComponent();
        BindingContext = vm;		        
    }
}