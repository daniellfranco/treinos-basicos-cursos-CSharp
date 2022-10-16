using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Comparação_Arrays_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Comparacao comparacao = new Comparacao();


            // interface

            Console.WriteLine("Digite o resultado da megasena: ");

            for(int i=0; i < 6; i++)
            {
                Console.WriteLine(i+1 + "o numero: ");
                comparacao.resultadoDaMega[i] = int.Parse(Console.ReadLine());
            }

            do
            {
                Console.WriteLine("Agora digite os seus numeros jogados: (limite de 6 numeros)");
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(i+1 + "o numero: ");
                    comparacao.meuJogoDaMega[i] = int.Parse(Console.ReadLine());
                }

                comparacao.comparacao();

                comparacao.repetir();

            } while (comparacao.continuar == true);


            Console.ReadLine();
        }
    }
}
