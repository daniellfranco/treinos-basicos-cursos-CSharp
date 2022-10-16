using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08GetSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();

            p.Nome = "Daniel";

            Console.WriteLine(p.Nome);


            Console.ReadLine();
        }
    }
}
