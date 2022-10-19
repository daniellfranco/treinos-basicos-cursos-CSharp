using ExcecoesEColecoes.Models;




//new ExemploExcecao().Metodo1();
new ExemploFila().MetodoFila();




try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo-Leitura.txt");

    foreach (string linha in linhas)
    {
        Console.WriteLine(linha);
    }
}
//Pode-se ter uma ou mais excessões
catch (FileNotFoundException ex)
{
    Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
}
//Só pode cair em uma excessão por vez, a que for compativel com o tipo de excessão
catch (DirectoryNotFoundException ex)
{
    Console.WriteLine($"Caminho da pasta não encontrado."
                                            + ex.Message);
}
//Se não for compativel com nenhuma das expecificas acima, ele cai na generica.
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
//o finally sempre é executado, idependente se uma excessão ocorrer ou não.
finally
{
    Console.WriteLine("Chegou Aqui");
    //Pode ser util para fechar conexões, por exemplo a de banco que o banco segura ela aberta até finalizar o acesso.
    //Ou para reportar aos devs se algo foi executado ou não com sucesso por exemplo.
}