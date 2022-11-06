using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TiposEspeciais.Models
{
    // para mais infos de serialização e deserialização ver o projeto SerializacaoEAtributos
    public class Deserializacao
    {
        public void MetodoDeserializacao()
        {
            string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

            List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

            foreach (Venda venda in listaVenda)
            {
                Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}, "
                //if ternario se tiver desconto coloca o texto de desconto, se for nulo não coloca.
                + (venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : ""));
            }
        }
    }
}