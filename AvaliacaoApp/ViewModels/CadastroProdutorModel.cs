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
    public partial class CadastroProdutorModel : ObservableObject
    {
        IConnectivity connectivity;
        DetalhesProdutorModel _detail;        

        public CadastroProdutorModel(IConnectivity connectivity)
        {
            Items = new ObservableCollection<Produtor>();
            this.connectivity = connectivity;
        }

        [ObservableProperty]
        ObservableCollection<Produtor> _items;

        [ObservableProperty]
        string _nome;

        [ObservableProperty]
        string _telefone;

        [ObservableProperty]
        string _fazenda;

        [RelayCommand] 
        async void Add()
        {
            if (string.IsNullOrWhiteSpace(Nome))
                 return;
            
             Items.Add(new Produtor(Nome, Telefone, Fazenda));
             App.ListaProdutor = new List<Produtor>(Items);
            
            Nome     = string.Empty;
            Telefone = string.Empty;
            Fazenda  = string.Empty;

            await Shell.Current.GoToAsync("..");
        }

        [RelayCommand]
        void Delete(string s)
        {
            if (Items.Any(item => item.Nome.Contains(s)))
            {                
                int index = 0;
                foreach (var item in Items)
                {
                    if (item.Nome == s) {
                      
                        break;
                    }                 
                    index++;
                }

                Items.RemoveAt(index);
            }
            
        }

        [RelayCommand]
        async Task Tap(string s)
        {           
            App.ProdutorSelecionado = s;
            await Shell.Current.GoToAsync($"{nameof(DetalhesProdutor)}");
        }
    }
}
