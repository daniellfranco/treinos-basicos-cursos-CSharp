using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Pessoa obj = new Pessoa();
            obj.apresentar();
            obj.apresentar("Daniel");
            obj.apresentar("Daniel", 27);

            Console.ReadLine();
        }
    }
}
