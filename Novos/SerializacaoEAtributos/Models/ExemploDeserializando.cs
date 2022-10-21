using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SerializacaoEAtributos.Models
{
    public class ExemploDeserializando
    {
        public void MetodoDeserializacao()
        {
            string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

            List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

            foreach (Venda venda in listaVenda)
            {
                Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
            }
        }
    }
}