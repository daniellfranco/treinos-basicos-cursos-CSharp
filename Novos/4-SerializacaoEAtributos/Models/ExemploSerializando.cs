using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace SerializacaoEAtributos.Models
{
    public class ExemploSerializando
    {
        public void MetodoSerializacao()
        {
            //o json representa as horas recebidas pelo datetime de 
            //forma independente, usando o padrão ISO 8601.
            DateTime dataAtual = DateTime.Now;

            //Use uma lista para serializar varios objetos juntos
            List<Venda> listaVendas = new List<Venda>();

            //objeto qualquer
            Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
            Venda v2 = new Venda(2, "Licença de Software", 150.00M, dataAtual);

            listaVendas.Add(v1);
            listaVendas.Add(v2);

            //metodo serializador que vai serializar nossa lista de objetos
            //ler documentação do Newtonsoft.Json para ter noção dos overloads disponiveis.
            string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);


            //da para serializar só um objeto qualquer só também
            //string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);

            //escrevendo o objeto serializado em um arquivo.
            File.WriteAllText("Arquivos/vendas.json", serializado);
            //obs: ele cria o arquivo vendas.json, mas não cria o diretorio
            //se nao tiver previamente o diretorio Arquivos ele da uma exception.

            Console.WriteLine(serializado);
        }
    }
}