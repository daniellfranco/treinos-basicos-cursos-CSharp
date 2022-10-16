using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ExercicioIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            // Instanciar Objeto
            Pessoa obj = new Pessoa();
            
            obj.altura = 1.75;
            obj.peso = 115.0;

            obj.mensagem();




            Console.ReadLine();
        }
    }
}
