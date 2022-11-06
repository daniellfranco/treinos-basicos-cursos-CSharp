using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TuplasTernarioEDesconstrucao.Models
{
    public class ExemploTuplas
    {
        public void MetodoTupla1()
        {
            //Declarando uma tupla
            //no primeiro parenteses você coloca todos os tipos que voce vai ocupar na tupla.
            //no segundo você declara eles, precisa ser na ordem dos tipos do primeiro parenteses.
            (int, string, string, decimal) tupla = (1, "Daniel", "Franco", 1.80M);

            //lendo os dados da tupla
            Console.WriteLine($"ID: {tupla.Item1}");
            Console.WriteLine($"Nome: {tupla.Item2}");
            Console.WriteLine($"Sobrenome: {tupla.Item3}");
            Console.WriteLine($"Altura: {tupla.Item4}");

            Console.WriteLine("----------------------------------------------");

            //também é possivel declarar o nome de cada tipo da tupla
            (int ID, string Nome, string Sobrenome, decimal Altura) tupla2 = (2, "Nayala", "Forest", 1.69M);

            Console.WriteLine($"ID: {tupla2.ID}");
            Console.WriteLine($"Nome: {tupla2.Item2}"); //pode ser lido usando Item ou o nome da variavel.
            Console.WriteLine($"Sobrenome: {tupla2.Sobrenome}");
            Console.WriteLine($"Altura: {tupla2.Altura}");

            Console.WriteLine("----------------------------------------------");

            //Também pode ser declarado das seguintes formas, mas o recomendado é a forma acima
            //Pois na acima dá para nomear as variaveis da tupla deixando ela mais legivel.
            ValueTuple<int, string, string, decimal> outroExemploTupla = (3, "Daniel", "Franco", 1.80M);

            Console.WriteLine($"ID: {outroExemploTupla.Item1}");
            Console.WriteLine($"Nome: {outroExemploTupla.Item2}");
            Console.WriteLine($"Sobrenome: {outroExemploTupla.Item3}");
            Console.WriteLine($"Altura: {outroExemploTupla.Item4}");

            Console.WriteLine("\n");

            var outroExemploTupla2 = Tuple.Create(4, "Nayala", "Forest", 1.69M);

            Console.WriteLine($"ID: {outroExemploTupla2.Item1}");
            Console.WriteLine($"Nome: {outroExemploTupla2.Item2}");
            Console.WriteLine($"Sobrenome: {outroExemploTupla2.Item3}");
            Console.WriteLine($"Altura: {outroExemploTupla2.Item4}");

            Console.WriteLine("----------------------------------------------\n");
        }

        public (bool Sucesso, string[] Linhas, int QuatidadeDeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);

                return (true, linhas, linhas.Count());
            }
            catch (Exception)
            {
                return (false, new string[0], 0);
            }
        }
    }
}