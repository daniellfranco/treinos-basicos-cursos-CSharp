using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacaoEAtributos.Models
{
    internal class Venda
    {

        // quando você for deserializar um arquivo json que você está recebendo
        // a principio você só precisa fazer uma classe contendo os atributos
        // iguais ao do arquivo json.
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }


        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }
    }
}
