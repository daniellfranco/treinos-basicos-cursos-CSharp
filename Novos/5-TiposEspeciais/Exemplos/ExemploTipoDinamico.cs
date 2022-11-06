using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEspeciais.Exemplos
{
    internal class ExemploTipoDinamico
    {
        public ExemploTipoDinamico()
        {
            //tipos dinamicos permitem ter seu tipo alterado conforme oque recebem

            //agora é int pois recebeu um inteiro
            dynamic variavelDinamica = 4;
            TextoWriteline(variavelDinamica);

            //Agora é uma string
            variavelDinamica = "Texto";
            TextoWriteline(variavelDinamica);

            //agora é booleano
            variavelDinamica = true;
            TextoWriteline(variavelDinamica);

            //é util em alguns casos dado seu dinamismo, mas pode ser perigoso,
            //uma confusão ao trabalhar com oque ela recebe e vai dar uma excessão.
        }

        private void TextoWriteline(dynamic variavelDinamica)
        {
            Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
        }
    }
}
