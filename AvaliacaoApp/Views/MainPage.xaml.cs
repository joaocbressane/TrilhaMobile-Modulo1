namespace AvaliacaoApp.Views
{
    public partial class MainPage : ContentPage
    {

        CadastroProdutorPage _cadProdutor;
        ListarProdutorPage _listarProdutor;
        SobrePage _sobre;

        public MainPage(CadastroProdutorPage vm, ListarProdutorPage lm, SobrePage sp)
        {
            InitializeComponent();
            _cadProdutor = vm;
            _listarProdutor = lm;
            _sobre = sp;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {            
        }

        private async void CadastrarBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(_cadProdutor);
        }

        private async void ListarBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(_listarProdutor);
        }

        private async void SobreBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(_sobre);
        }
    }

}
