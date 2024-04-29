using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoApp.Models
{
    public class Produtor
    {
        public Produtor(string nome, string telefone, string fazenda )
        {
            Nome = nome;
            Telefone = telefone;
            Fazenda = fazenda;
        }            

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Fazenda { get; set; }
        
    }
}
