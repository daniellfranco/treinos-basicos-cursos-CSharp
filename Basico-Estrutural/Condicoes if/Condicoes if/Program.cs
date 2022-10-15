using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicoes_if
{
    internal class Program
    {
        static void Main(string[] args)
        {

            if (10 > 20)
            {
                Console.WriteLine("É VERDADE");
            }else if (20 < 30)
            {
                //else if serve como segundo teste quando o primeiro falha
                //da pra ter quantos else if quiser
                Console.WriteLine("Executou else if");
            }
            else
            {
                //se o if e todos os else if falharem ele cai no else
                Console.WriteLine("é mentira");
            }

            /////////////////
            ///

            int idade;

            //é necessario usar parse para converter oq foi escrito em numero
            //pois do contrario ele reconhece como string.
            Console.WriteLine("Digite sua idade: ");
            idade = int.Parse(Console.ReadLine());


            if(idade >= 0 && idade <= 11)
            {
                Console.WriteLine("Você é uma criança!");
            }else if(idade >= 12 && idade <= 18)
            {
                Console.WriteLine("Você é um adolescente!");
            }else if(idade >= 19 && idade <= 60){
                Console.WriteLine("Voce é um adulto!");
            }
            else
            {
                Console.WriteLine("Voce é um idoso!");
            }



            Console.ReadLine();

        }
    }
}
