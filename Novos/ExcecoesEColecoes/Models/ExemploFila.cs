using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcecoesEColecoes.Models
{
    public class ExemploFila
    {

        //filas adicionam e removem itens na ordem de entrada,
        //o primeiro a entrar é o primeiro a sair.
        public void MetodoFila()
        {

            Queue<int> fila = new Queue<int>();

            //Enqueue adiciona um valor
            fila.Enqueue(2);
            fila.Enqueue(4);
            fila.Enqueue(6);
            fila.Enqueue(8);


            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }

            //Dequeue remove um valor
            Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
            //esse valor vai entrar no final da fila
            fila.Enqueue(10);

            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }

        }


    }
}