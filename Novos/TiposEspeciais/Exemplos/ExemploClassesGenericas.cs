using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposEspeciais.Models;

namespace TiposEspeciais.Exemplos
{
    internal class ExemploClassesGenericas
    {
        public ExemploClassesGenericas()
        {
            //As classes genéricas elas agem sempre da mesma forma idependente do tipo definido pra ela.

            //voce cria a classe com um tipo generico,
            ////e só aqui na hora de instanciar voce define o tipo que ela vai ser.
            MeuArray<int> arrayInteiro = new MeuArray<int>();
            arrayInteiro.AdicionarElementoArray(30);
            Console.WriteLine(arrayInteiro[0]);

            //agora foi definido como string e vai passar a trabalhar e exigir string
            MeuArray<string> arrayString = new MeuArray<string>();
            arrayString.AdicionarElementoArray("Teste");
            Console.WriteLine(arrayString[0]);
        }
    }
}
