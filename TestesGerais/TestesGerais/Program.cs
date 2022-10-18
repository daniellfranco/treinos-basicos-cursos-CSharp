using TestesGerais;
using System.Globalization;

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1522.55M;
Console.WriteLine($"{valorMonetario:c}");
Console.WriteLine(valorMonetario.ToString("C"));
Console.WriteLine(valorMonetario.ToString("C4"));
Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

Console.WriteLine(valorMonetario.ToString("N"));

double porcentagem = .12;
Console.WriteLine($"{porcentagem:P}");

int numero = 123456;
//formatação manual, # representa um digito.
Console.WriteLine(numero.ToString("##-##-##"));

/*

    int n = int.Parse(Console.ReadLine());
    int count = 0;

    for (int i = 1; i <= n; i++)
    {
        // TODO: Crie as outras condições necessárias para a resolução do desafio:
        if (n % i == 0)
        {
            count++;
        }
        if (count > 3)
        {
            Console.WriteLine(false);
        }
    }
    Console.WriteLine(count == 3);


/*
Console.WriteLine("Digite a quantidade de casos: ");
int qt = int.Parse(Console.ReadLine());
string[] v = new string[qt];

for (int i = 0; i < qt; i++)
{

    Console.WriteLine("Digite os 2 Numeros separados por espaço: ");

    // Separa os 2 numeros em vetores a partir do espaço
    v = Console.ReadLine().Split(" ");

    string a = v[0];

    string b = v[1];

    if (a.Length > 0 && a.Length <= 1000 && b.Length < 0 && b.Length >= 1000)
        Console.WriteLine("nao encaixa");
    else if (a.EndsWith(b))
        Console.WriteLine("encaixa");
    else
        Console.WriteLine("nao encaixa");

}


/*
int qt = 4;
// TODO: Crie as outras condições necessárias para a resolução do desafio:
for (int i = 0; i < qt; i++)
{

    string a = "56234523485723854755454545478690";
    string b = "78690";

    if (a.Length < b.Length)
        Console.WriteLine("nao encaixa");
    else if (a.Substring(a.Length - b.Length) == b)
        Console.WriteLine("encaixa");
    else
        Console.WriteLine("nao encaixa");

}



/*

// Teste listas

List<string> listaString = new List<string>();
List<float> listaFloat = new List<float>();

// Add um item por vez, não da para por virgula e adicionar varios.
listaString.Add("aaaa");

listaFloat.Add(2.58f);

Console.WriteLine(listaString[0]);
Console.WriteLine(listaFloat[0]);
Console.WriteLine(listaFloat.Count);


// Teste summary, passe o mouse sobre o nome da classe e do metodo
TesteSummary testeSummary = new TesteSummary();

testeSummary.PasseOMouseAquiSummary();

// Quando você está digitando os parametros ele mostra o comentario exclusivo do parametro para documentar sua função. 
Console.WriteLine(testeSummary.SomaPasseOMouseSummary(2, 3));

*/