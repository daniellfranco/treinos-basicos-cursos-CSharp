using TuplasTernarioEDesconstrucao.Models;

// TUPLAS

ExemploTuplas exemploTuplas = new ExemploTuplas();

//exemploTuplas.MetodoTupla1();

var (sucesso, linhasArquivo, quantidadeLinhas) = exemploTuplas.LerArquivo("Arquivos/ArquivoTexto.txt");

//se por acaso algum dos retornos não for necessario em algum momento, pode-se
//por um _ (underline) no lugar da variavel que vc não vai usar
//exemplo:
//var (sucesso, _, quantidadeLinhas) = exemploTuplas.LerArquivo("Arquivos/ArquivoTexto.txt");
//ai não cria variavel desnecessaria e melhora a legibilidade do codigo

if (sucesso)
{
    Console.WriteLine($"Quantidade de linhas do arquivo: {quantidadeLinhas}");
    foreach (string linha in linhasArquivo)
    {
        Console.WriteLine(linha);
    }
}
else
{
    Console.WriteLine("Não foi possivel ler o arquivo.");
}

// IF TERNARIO

int numero = 10;
bool ehPar = false;

ehPar = numero % 2 == 0;
//if ternario é um if mais simples feito dessa forma,
//se o ehPar for true, ele joga o primeiro dado, senao joga o segundo apos o :
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));

// DESCONSTRUTOR

//construtor com os dados
ExemploDesconstrutor p1 = new ExemploDesconstrutor("Daniel", "Franco");

//desconstrutor devolvendo os dados, similar a tupla
(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");


