using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplasTernarioEDesconstrucao.Models
{
    internal class ExemploDesconstrutor
    {

        public string Nome { get; set; }

        public string Sobrenome { get; set; }

        //Construtor adiciona os dados
        public ExemploDesconstrutor(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        //Descontrutor devolve os dados
        public void Deconstruct(out string nome, out string sobrenome)
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        
    }
}
