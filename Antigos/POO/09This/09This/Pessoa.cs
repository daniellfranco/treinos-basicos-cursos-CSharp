using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09This
{
    internal class Pessoa
    {

        // Atributo

        private string nome = "Daniel";

        public Pessoa(string nome)
        {
            //Detalhe: Ambos atributo e parametro tem o mesmo nome

            //Sem o this ele pega o valor do parametro
            Console.WriteLine(nome);

            //Com o this ele pega o valor do atributo
            Console.WriteLine(this.nome);
        }


    }
}
