using ExemplosPOO.Interfaces;
using ExemplosPOO.Models;

//Calculadora calc = new Calculadora();
//da para instanciar tanto da forma comentada acima, quanto usando a interface.
ICalculadora calc = new Calculadora();
Console.WriteLine(calc.somar(2, 2));

//Abaixo exemplo de classe Abstrata
Corrente c = new Corrente();
c.Creditar(500);
c.ExibirSaldo();
/////////////////////////////////////////
//Abaixo exemplo de herança e polimorfismo
Aluno a1 = new Aluno("Daniel");
a1.Idade = 27;
a1.Nota = 10;

a1.Apresentar();

Professor p1 = new Professor("Nayala");
p1.Idade = 26;
p1.Salario = 5000M;

p1.Apresentar();
/////////////////////////////////////////////////