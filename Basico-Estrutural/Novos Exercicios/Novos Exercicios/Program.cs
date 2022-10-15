using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novos_Exercicios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nome = null;
            
            
            Console.WriteLine("Escreva seu nome: ");

            nome = Console.ReadLine();

            Console.WriteLine("Seu nome é: ");
            Console.WriteLine(nome);

            //////////////////////////////////
            ///


            //no c# se uma divisão pode dar um numero com virgula, pelo menos um dos valores tem q ta com um F no final,
            //senao, mesmo q teja em float ele vai cortar o valor depois da virgula.
            //como no exemplo abaixo, se tiver um f ele vai retornar 2.5, se nenhum tiver um f vai retornar 2.
            //e se fizer uma operação com 1 numero float q resulte num valor inteiro, vc tem q jogar ele dentro de uma variavel float
            //pq a operação fica tipo o resultado como 2.0 ao inves de só 2, por exemplo.
            float numero = 5 / 2f;

            Console.WriteLine(numero);

            //////////////////////////////////////////
            


            Console.ReadLine();
        }
    }
}
