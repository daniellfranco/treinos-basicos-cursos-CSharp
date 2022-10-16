using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase_e_Enum
{
    internal class Program
    {

        enum Opcao { Criar = 1, Deletar, Editar, Atualizar }
        //enum é tipo um vetor q vc pode configurar, por exemplo se vc
        //botar um =1 ele no primeiro item, ao inves de ser o item 0 ele
        //vai ser o item 1, se o segundo item tiver um =30 ao inves de ser
        //item 2 ele vai ser item 30 e o proximo se nao for colocado
        //nenhuma alteração vai seguir a sequencia e ser o item 31.


        static void Main(string[] args)
        {
            string cor = "Azul";

            switch (cor)
            {
                case "Vermelho":
                    Console.WriteLine("Sua cor favorita é vermelho");
                    break;
                case "Amarelo":
                    Console.WriteLine("Sua cor favorita é Amarelo");
                    break;
                case "Azul":
                    Console.WriteLine("Sua cor favorita é Azul");
                    break;
                default:
                    Console.WriteLine("Sua cor favorita é desconhecida");
                    break;
            }


            Console.WriteLine("Selecione uma das opções abaixo: ");
            Console.WriteLine("1-Criar\n2-Deletar\n3-Editar\n4-Listar\n5-Atualizar");
            int index = int.Parse(Console.ReadLine());
            Opcao opcaoSelecionada = (Opcao)index;

            switch (opcaoSelecionada)
            {
                case Opcao.Criar:
                    Console.WriteLine("Você quer criar algo!");
                    break;
                case Opcao.Deletar:
                    Console.WriteLine("DELETE! DELETE IMEDIATAMENTE!");
                    break;
                case Opcao.Atualizar:
                    Console.WriteLine("Editar é muito bom!");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada!");
                    break;
            }


            Console.ReadLine();
        }
    }
}
