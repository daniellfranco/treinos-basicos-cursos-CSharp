using SerializacaoEAtributos.Models;
using Newtonsoft.Json;

//metodo qualquer
Venda v1 = new Venda(1, "Material de escritório", 25.00M);

//metodo serializador que vai serializar nosso metodo qualquer
//ler documentação para ter noção dos overloads disponiveis.
string serializado = JsonConvert.SerializeObject(v1, Formatting.Indented);


Console.WriteLine(serializado);