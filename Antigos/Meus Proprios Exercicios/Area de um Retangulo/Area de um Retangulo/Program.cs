using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_um_Retangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exercicio encontrado no site:
            //https://dfilitto.com.br/desenvolvimento/c-sharp/lista-de-exercicios-de-programacao-orientada-a-objetos-em-c-1-parte/

            //solução do site
            Retangulo retangulo = new Retangulo();
            
            Console.WriteLine("Calcula a area de um retangulo");
            Console.Write("Informe a altura: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe a bas/largura: ");
            retangulo.Base = Convert.ToDouble(Console.ReadLine());
            retangulo.ExibirDados();


            /*
            
            //Minha tentativa
            Retangulo ret = new Retangulo();

            Console.WriteLine("Digite a altura do retangulo:");

            ret.alturaRetangulo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a base do retangulo:");

            ret.baseRetangulo = double.Parse(Console.ReadLine());

            ret.mensagem(ret.baseRetangulo, ret.alturaRetangulo);
            
            
            */



            /////////////////////

            Console.ReadLine();

        }
    }
}
