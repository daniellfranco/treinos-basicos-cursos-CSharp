using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ExercicioEscolar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Instaciar objeto da classe Aluno
            Aluno a = new Aluno();
            a.nome = "Nayala";
            a.nota1 = 8;
            a.nota2 = 10;

            a.mensagem();

            Console.ReadLine();
        }
    }
}
