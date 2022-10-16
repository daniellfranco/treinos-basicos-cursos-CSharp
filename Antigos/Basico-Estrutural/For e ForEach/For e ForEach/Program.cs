using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_e_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] palavras = { "nay", "floresta", "soul", "ciano", "azul" };

            int[] numeros = { 1, 22, 43, 92, 38, 74, 11, 01, 88, 00 };

            //foreach executa o loop conforme a quantia de elementos q tem no array, e coloca o elemento dentro da variavel
            foreach(string palavra in palavras)
            {
                Console.WriteLine(palavra);
            }

            foreach(int num in numeros)
            {
                Console.WriteLine(num);
            }


            for(int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("==========================================");
            Console.WriteLine(numeros.Length);
            for (int i = numeros.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numeros[i]);
            }

            Console.ReadLine();

        }
    }
}
