using AvaliacaoApp.Models;

namespace AvaliacaoApp
{
    public partial class App : Application
    {

        public static List<Produtor> ListaProdutor {get; set;}
        public static string ProdutorSelecionado { get; set;}

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
