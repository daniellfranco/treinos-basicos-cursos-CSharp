using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SerializacaoEAtributos.Models
{
    internal class VendaDeserializacao
    {
        //motivo de criar um especifico para serialização foi
        //que no exemplo da aula tem um caso que se fizer no outro da problema

        //o caso é que quando você recebe um arquivo json que tem uma propriedade com nome diferente
        //que utilize uma convenção diferente e que você não possa alterar só para bater com a convenção do C#
        //exemplo Nome_Produto, sendo que pelas convenções do C# deveria então ser NomeProduto


        public int Id { get; set; }

        //Então você pode utilizar um atributo da blibioteca Newtonsoft.Json
        //que diz pro deserializador que você vai receber uma propriedade com um nome
        //e vai jogar na propriedade abaixo que está com outro nome
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
