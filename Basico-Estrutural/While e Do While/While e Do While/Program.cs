using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_e_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while(contador < 10)
            {
                Console.WriteLine("Executou while!");
                /*
                contador = contador + 1;
                ou
                contador += 1;
                ou também da para fazer assim: 
                */
                contador++;
            }
            Console.WriteLine("Passou o while!");


            //o DoWhile é igual o while mas ele executa o codigo pelo menos 1 vez mesmo q a condição seja já inicialmente falsa.
            do
            {
                Console.WriteLine("Executou DoWhile");
            } while (false);
            Console.WriteLine("Passou o DoWhile");    






            Console.ReadLine();
        }
    }
}
