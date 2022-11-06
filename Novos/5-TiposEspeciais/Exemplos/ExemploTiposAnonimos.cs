using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiposEspeciais.Models;

namespace TiposEspeciais.Exemplos
{
    internal class ExemploTiposAnonimos
    {
        public ExemploTiposAnonimos()
        {
            //tipos anonimos são parecidos com tuplas, mas com a desvantagem que não podem ser editados depois
            //e nem ser usados para retornar metodos, mas ele serve para representar
            // algum objeto novo somente com propriedades que você queira que ele retorne
            // como se você desconstruisse algum objeto e fazendo um tipo anonimo só com os dados que voce queira.

            var tipoAnonimo = new { Nome = "Daniel", Sobrenome = "Franco", Altura = 1.80 };

            Console.WriteLine("Nome: " + tipoAnonimo.Nome);
            Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
            Console.WriteLine("Altura: " + tipoAnonimo.Altura);

            string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

            List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

            //Select serve para fazer uma seleção de dado,
            //o x representa um elemento da lista
            //no new você tem um tipo anonimo que atravez dele voce pega o produto e o preco,
            //criando assim um novo objeto coleção de tipos anonimos.
            var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

            foreach (var venda in listaAnonimo)
            {
                Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
            }
        }
    }
}
