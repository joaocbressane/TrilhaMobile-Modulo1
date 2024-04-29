
using AvaliacaoApp.ViewModels;

namespace AvaliacaoApp.Views;

public partial class DetalhesProdutor : ContentPage
{
	public DetalhesProdutor(DetalhesProdutorModel vm)
	{
        BindingContext = vm;
        InitializeComponent();        
    }
}