using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesEColecoes.Models
{
    internal class ExemploPilha
    {

        public void MetodoPilha()
        {
            Console.WriteLine("Teste Pilha/Stack");

            Stack<int> pilha = new Stack<int>();

            pilha.Push(2);
            pilha.Push(4);
            pilha.Push(6);
            pilha.Push(8);


            foreach(int item in pilha)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

            pilha.Push(20);

            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }



        }



    }
}
