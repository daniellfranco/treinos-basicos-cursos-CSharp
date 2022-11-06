using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcecoesEColecoes.Models
{
    internal class ExemploDictionary
    {

        public void MetodoDictionary()
        {

            Console.WriteLine("Teste Dictionary");

            //Dictionary é uma forma de guardar dados com chaves unicas e não alteraveis em tempo de execução.
            //o valor pode ser alterado, mas a chave não, se precisar mudar uma chave vai ter que deletar e criar denovo.

            //         chave - valor
            Dictionary<string, string> estados = new Dictionary<string, string>();
            //no primeiro campo é necessario uma chave unica, pode ser uma string, int, etc, mas nao pode ser REPETIDO
            //no segundo campo pode ser qualquer texto e pode ser repetido.
            estados.Add("SP", "São Paulo");
            estados.Add("BA", "Bahia");
            estados.Add("MG", "Minas Gerais");
            estados.Add("PR", "Paraná");
            estados.Add("SC", "Santa Catarina");


            //para ler um valor é como array mas com o valor da chave.
            Console.WriteLine(estados["SC"]);

            Console.WriteLine("-------");

            foreach (var item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            Console.WriteLine("-------");

            //para remover é só especificar a chave.
            estados.Remove("MG");

            //para alterar o valor, é como um array, mas você passa a chave.
            estados["SP"] = "São Paulo - Valor Alterado";


            foreach (var item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }


            //Se tentar adicionar um item com a mesma chave o dictionary não permite e da uma exception
            //estados.Add("BA", "Bahia");

            Console.WriteLine("-------");

            string chave = "BA";
            Console.WriteLine($"Verificando o elemento: {chave}");

            //ContainsKey verifica a existencia de uma chave
            if (estados.ContainsKey(chave))
            {
                Console.WriteLine($"Valor existente: {chave}");
            }
            else
            {
                Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
            }

        }


    }
}
