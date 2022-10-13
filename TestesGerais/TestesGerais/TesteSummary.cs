using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesGerais
{
    /// <summary>
    /// Teste desta tag summary, ela mostra informação da classe quando passa o mouse em cima.
    /// </summary>
    internal class TesteSummary
    {
        /// <summary>
        /// Teste tag summary, ela também mostra informação do metodo.
        /// </summary>
        public void PasseOMouseAquiSummary()
        {
            Console.WriteLine("Passe o mouse em cima do metodo para ver o texto");
        }

        /// <summary>
        /// Soma dois valores
        /// </summary>
        /// <param name="x">Primeiro valor a ser somado</param>
        /// <param name="y">Segundo valor a ser somado</param>
        /// <returns>Retorna a soma dos valores</returns>
        public int SomaPasseOMouseSummary(int x, int y)
        {
            //Console.WriteLine($"Resultado soma {x} + {y} = {x + y}");
            return x + y;
        }
    }
}
