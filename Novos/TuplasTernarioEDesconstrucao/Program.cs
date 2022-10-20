using TuplasTernarioEDesconstrucao.Models;



ExemploTuplas exemploTuplas = new ExemploTuplas();

//exemploTuplas.MetodoTupla1();

var (sucesso, linhasArquivo, quantidadeLinhas) = exemploTuplas.LerArquivo("Arquivos/ArquivoTexto.txt");

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