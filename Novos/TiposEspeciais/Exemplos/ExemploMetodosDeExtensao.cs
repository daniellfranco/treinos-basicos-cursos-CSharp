using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//para funcionar a extensão, é preciso que onde ela for usada seja chamado o local que ela está
using TiposEspeciais.Models; 

namespace TiposEspeciais.Exemplos
{
    internal class ExemploMetodosDeExtensao
    {
        public ExemploMetodosDeExtensao()
        {
            int numero = 20;
            bool par = false;

            //metodo de extensão consistem em extender o uso de um metodo a um tipo de variavel
            //exemplo aqui é que adicionamos o metodo EhPar ao tipo int, então
            //toda variavel do tipo int vai ter o metodo EhPar() para ser usado.
            par = numero.EhPar();

            Console.WriteLine($"O número {numero} é {(par ? "par" : "ímpar")}");
        }
    }
}
