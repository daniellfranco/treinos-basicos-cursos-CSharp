using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;

            int[] array = new int[3] { 300, 500, 1000 };

            ExibirMsg();
            GerarPreco(-5, "Bolo");

            Console.WriteLine(Somar(array[0], array[1], array[2]));

            soma = Somar(22, 45, 12);
            Console.WriteLine(soma);

            Console.ReadLine();

        }

        static void ExibirMsg()
        {
            Console.WriteLine("Esse sistema é show de bola!");
            Console.WriteLine("Estou usando Funções!");
            Console.WriteLine("Bem Vindo!");
        }

        static void GerarPreco(int preco, string nome)
        {
            int precoAbs = Math.Abs(preco); //transforma o valor recebido em positivo caso seja negativo
            int valorFinal = precoAbs + (2 * precoAbs);
            Console.WriteLine(nome + " custa: " + valorFinal );
        }

        static int Somar(int a, int b, int c)
        {
            /*int resultadoFinal = a + b + c;
            return resultadoFinal;*/
            return a + b + c;
        }


    }
}
