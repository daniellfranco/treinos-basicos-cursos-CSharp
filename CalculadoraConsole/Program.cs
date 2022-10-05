using CalculadoraConsole.Models;

Calculadora calc = new Calculadora();

calc.Somar(10.5f, 20);
calc.Subtrair(10.5f, 20);
calc.Multiplicar(2, 10);
calc.Dividir(10, 2);
calc.Dividir(10, 3);

//-----------------
//usando a lib Math
calc.Potencia(10, 2);
calc.Seno(15);
calc.Coseno(15);
calc.Tangente(15);
calc.RaizQuadrada(9);