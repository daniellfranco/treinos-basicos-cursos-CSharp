using TiposEspeciais.Models;

Console.WriteLine("----------------------------------");
Console.WriteLine("Tipos Anonimos\n");

//tipos anonimos são parecidos com tuplas, mas com a desvantagem que não podem ser editados depois
//e nem ser usados para retornar metodos, mas ele serve para representar
// algum objeto novo somente com propriedades que você queira que ele retorne
// como se você desconstruisse algum objeto e fazendo um tipo anonimo só com os dados que voce queira.

var tipoAnonimo = new { Nome = "Daniel", Sobrenome = "Franco", Altura = 1.80 };

Console.WriteLine("Nome: " + tipoAnonimo.Nome);
Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
Console.WriteLine("Altura: " + tipoAnonimo.Altura);


Console.WriteLine("----------------------------------");
Console.WriteLine("Tipos Nulos\n");
// a interrogação ? indica que o valor pode receber null, do contrario no caso do bool seria só true ou false.
bool? desejaReceberEmail = null;

//.HasValue retorna true ou false caso ele tenha ou não um valor, pois se estiver null causa uma exception no if.
//.Value retorna se o conteudo do bool? é true ou false pro if.
//quando não tem o ? não precisa do .Value, mas quando tem se não por o .Value ele não funciona direto como quando não tem.
if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
{
    Console.WriteLine("O usuário optou por receber e-mail.");
}
else
{
    Console.WriteLine("O usuário não respondeu ou não optou por receber e-mail.");
}

Console.WriteLine("\n");

// exemplo de deserialização com valor nulo.
new Deserializacao().MetodoDeserializacao();

Console.WriteLine("----------------------------------");