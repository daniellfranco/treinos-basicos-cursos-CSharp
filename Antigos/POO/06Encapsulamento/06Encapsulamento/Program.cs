using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno a = new Aluno();
            a.mensagem();

            /*
             Encapsulamento é ter os metodos e variaveis,
             que só a classe vai utilizar internamente em
             seus metodos, *como privados*, assim eles não
             aparecerão no objeto. somente oque é para ser
             usado fora vai aparecer.
             isso aumenta a segurança do projeto alem de
             deixar mais limpo na hora de usar o objeto.

             */



            Console.ReadLine();
        }
    }
}
