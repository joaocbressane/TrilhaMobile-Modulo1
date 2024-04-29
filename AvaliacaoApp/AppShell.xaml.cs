using AvaliacaoApp.Views;

namespace AvaliacaoApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(DetalhesProdutor), typeof(DetalhesProdutor));
            
        }
    }
}
