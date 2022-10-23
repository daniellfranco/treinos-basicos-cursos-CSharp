using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEspeciais.Models
{
    public static class MetodoDeExtensaoInt
    {
        //o segredo da extensão é o "this int"
        //significa que toda variavel inteira vai ter disponivel
        //o metodo EhPar para usar como .EhPar();
        //e não precisa colocar um parametro, pois quando coloca o this
        //a propria variavel ja vai ser o parametro exemplo:
        //numero.EhPar(); a propria variavel numero ja é o parametro.
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}
