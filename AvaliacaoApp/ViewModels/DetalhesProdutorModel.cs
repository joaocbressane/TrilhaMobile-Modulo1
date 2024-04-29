using AvaliacaoApp.Models;
using AvaliacaoApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoApp.ViewModels
{
    
    public partial class DetalhesProdutorModel : ObservableObject
    {
        public DetalhesProdutorModel()
        {
            Dados = new ObservableCollection<Produtor>();           
            SetProdutor();
        }        

        [ObservableProperty]
        private ObservableCollection<Produtor> _dados;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
        void SetProdutor()
        {  
         
            foreach (var listaProdutor in App.ListaProdutor)
            {
                if (listaProdutor.Nome == App.ProdutorSelecionado)
                {
                    Dados.Add(listaProdutor);
                }
            }
        }

    }
}
