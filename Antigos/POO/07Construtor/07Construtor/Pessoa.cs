using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Construtor
{
    internal class Pessoa
    {

        /*
         Toda vez q instanciar um objeto (Pessoa p = new Pessoa())
        ele vai executar o construtor q é esse Public Pessoa(){}
        */

        // Construtor
        public Pessoa()
        {
            Console.WriteLine("Construtor executado");
        }

        // Assim como metodos da pra ter mais de um construtor
        // usando parametros diferentes

        public Pessoa(string nome)
        {
            Console.WriteLine("Olá "+nome);
        }
        
    }
}
