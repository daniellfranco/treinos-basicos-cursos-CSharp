using TiposEspeciais.Exemplos;


Separacao();

Console.WriteLine("Tipos Nulos\n");
new ExemploTiposNulos();

Separacao();
Console.WriteLine("Tipos Anonimos\n");
new ExemploTiposAnonimos();

Separacao();
Console.WriteLine("Tipo Dinamico\n");
new ExemploTipoDinamico();

Separacao();
Console.WriteLine("Classes Genericas\n");
new ExemploClassesGenericas();

Separacao();
Console.WriteLine("Metodos de Extensão\n");
new ExemploMetodosDeExtensao();

Separacao();






void Separacao()
{
    Console.WriteLine("--------------------------------------------");
}