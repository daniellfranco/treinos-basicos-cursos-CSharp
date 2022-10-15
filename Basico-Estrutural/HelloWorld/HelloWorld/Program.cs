using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //esse modulo serve para o programa usar
                              //multiplos nucleos do pc, nao chega ser necessario.

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {

             /*
             toggle block comment 
             ctrl+shift+;
             */

            int anoDeNascimento = 1995;
            string cor_favorita = "ciano";
            float altura1 = 178.5f;
            bool bonito = true;
            //lembrete não da pra repetir nome de variavel no mesmo escopo

            Console.WriteLine("Hello World!");
            Console.WriteLine("Meu nome é Daniel");
            Console.WriteLine(anoDeNascimento);
            Console.WriteLine(cor_favorita);
            Console.WriteLine(altura1);
            Console.WriteLine(bonito);

            altura1 = 177.5f;

            Console.WriteLine(altura1);


            ////////////////////////////////////////////////////////////////////////////////////////////////


            //da para definir variavel com var igual no javascript, mas é uma forma preguiçosa e nao mt recomendavel
             var qualquerNumero = 12345;
             var textaoDeTeste = "textotextotextotextão";
            //mas não pode tentar mudar o tipo depois, uma vez q o programa executa e define o tipo ele vai ser desse tipo pra sempre
            Console.WriteLine(qualquerNumero);
            Console.WriteLine(textaoDeTeste);

            ////////////////////////////////////////////////////////////////////////////////////////////////

            //existe um tipo de variavel dinamica q depois pode ser mudado o tipo
            dynamic variavelDinamica = "teste";
            Console.WriteLine(variavelDinamica);
            //depois da pra transformar ela em outra coisa
            variavelDinamica = 1235.6f;
            Console.WriteLine(variavelDinamica);
            //mas essa é a menos recomendada a ser usada, pois quebra o padrão tipado da linguagem, e tem menos desempenho, talvez só em um caso muuuito especifico.

            /////////////////////////////////////////////////////////////////////////////////////////////////

            //constantes podem ser qualquer variavel com um "const" na frente, ele torna a variavel "não editavel" ela vai ser assim sempre.
            const float pi = 3.14159265359f;

            Console.WriteLine(pi);
            ///////////////////////////////////////////////////////////////////////////////////////////////////



            Console.ReadLine();

        }
    }
}
