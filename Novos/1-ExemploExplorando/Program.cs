using ExemploExplorando.Models;


Pessoa p1 = new Pessoa();
p1.Nome = "Daniel";
p1.Sobrenome = "Franco";

Pessoa p2 = new Pessoa("Nayala", "Forest");

/* esse nome: e sobrenome:, é o nome do parametro, serve apenas de 
recurso visual para melhorar a legibilidade, e tem que ser o mesmo
 nome do parametro senao nao funciona. */
Pessoa p3 = new Pessoa(nome: "Ashley", sobrenome: "Evergarden");

/* na verdade também serve pra caso queira inverter a ordem do
 parametro, mas porque você vai querer fazer isso nao sei. */
Pessoa p4 = new Pessoa(sobrenome: "Evergarden", nome: "Ashley");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.AdicionarAluno(p4);
cursoDeIngles.ListarAlunos();


/*
Pessoa p1 = new Pessoa();
p1.Nome = "Daniel";
p1.Sobrenome = "Franco";
p1.Idade = 27;
p1.Apresentar();

*/