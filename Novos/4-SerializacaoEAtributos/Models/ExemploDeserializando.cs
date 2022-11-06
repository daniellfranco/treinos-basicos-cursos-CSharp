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
            string conteudoArquivo = File.ReadAllText("Arquivos/vendasComPropriedadeDiferente.json");

            List<VendaDeserializacao> listaVenda = JsonConvert.DeserializeObject<List<VendaDeserializacao>>(conteudoArquivo);

            foreach (VendaDeserializacao venda in listaVenda)
            {
                Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
                $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");
            }
        }
    }
}