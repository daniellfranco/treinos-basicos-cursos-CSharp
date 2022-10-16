using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _03ExercicioEscolar
{
    internal class Aluno
    {
        //Atributos
        public string nome;

        public double nota1, nota2;

        //Média
        public double media()
        {
            return (nota1 + nota2) / 2;
        }


        //Situação
        public string situacao(double media)
        {

            //Operador Ternario, retorno rapido e enxuto
            /*
            O operador ternário( ? : ) funciona assim:

            Você tem uma condição que deve ser validada
                como verdadeira ou falsa.

             Se a condição for verdadeira o operador retorna
                uma expressão e se for falsa retorna outra expressão.
            */

            return media >= 7 ? "aprovado(a)" : "reprovado(a)";
            //pode ser booleano, string, int, float etc...
        }

        //Mensagem
        public void mensagem()
        {
            //Obter a Média
            double obterMedia = media();

            //Obter a situação
            string obterSituacao = situacao(obterMedia);

            //Mensagem
            Console.WriteLine(nome + " está " + obterSituacao + " com média " + obterMedia);
        }

    }
}
