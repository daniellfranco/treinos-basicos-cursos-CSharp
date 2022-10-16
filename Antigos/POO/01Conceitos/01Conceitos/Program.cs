using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Conceitos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciar um objeto
            Pessoa obj = new Pessoa();
            //-------------

            obj.nome = "Daniel";
            obj.idade = 27;
            obj.mensagem();

            Console.ReadLine();
        }
    }
}
