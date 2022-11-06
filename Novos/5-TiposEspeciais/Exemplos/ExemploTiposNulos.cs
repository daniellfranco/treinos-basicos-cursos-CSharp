using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposEspeciais.Models;

namespace TiposEspeciais.Exemplos
{
    internal class ExemploTiposNulos
    {
        public ExemploTiposNulos()
        {
            // a interrogação ? indica que o valor pode receber null, do contrario no caso do bool seria só true ou false.
            bool? desejaReceberEmail = null;

            //.HasValue retorna true ou false caso ele tenha ou não um valor, pois se estiver null causa uma exception no if.
            //.Value retorna se o conteudo do bool? é true ou false pro if.
            //quando não tem o ? não precisa do .Value, mas quando tem se não por o .Value ele não funciona direto como quando não tem.
            if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
            {
                Console.WriteLine("O usuário optou por receber e-mail.");
            }
            else
            {
                Console.WriteLine("O usuário não respondeu ou não optou por receber e-mail.");
            }

            Console.WriteLine("\n");

            // exemplo de deserialização com valor nulo.
            new Deserializacao().MetodoDeserializacao();
        }
    }
}
