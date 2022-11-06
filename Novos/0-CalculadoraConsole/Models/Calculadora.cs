using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraConsole.Models
{
    public class Calculadora
    {

        public void Somar(float x, float y)
        {
            Console.WriteLine($"{x} + {y} = {x + y}");
        }

        public void Subtrair(float x, float y)
        {
            Console.WriteLine($"{x} - {y} = {x - y}");
        }

        public void Multiplicar(float x, float y)
        {
            Console.WriteLine($"{x} x {y} = {x * y}");
        }

        public void Dividir(float x, float y)
        {
            Console.WriteLine($"{x} / {y} = {x / y}");
        }

        //---------------------------------------------------------------------

        public void Potencia(float x, float y)
        {
            //Math é uma biblioteca de codigos de calculos matematicos.
            Console.WriteLine($"{x}^{y} = {Math.Pow(x, y)}");
            //ps: Math.Pow que faz a potencia, recebe um dado do tipo Double.
        }

        public void Seno(double angulo)
        {
            //a lib math usa um angulo medido em radianos, por isso tem q converter para radiano.
            double radiano = angulo * Math.PI / 180; //Math.PI dá o valor de PI.
            double seno = Math.Sin(radiano);
            //Math.round(var, digitosDepoisDaVirgula) arredonda o valor da variavel conforme o numero de casas colocadas.
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }

        public void Coseno(double angulo)
        {
            //a lib math usa um angulo medido em radianos, por isso tem q converter para radiano.
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            //Math.round(var, digitosDepoisDaVirgula) arredonda o valor da variavel conforme o numero de casas colocadas.
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo)
        {
            //a lib math usa um angulo medido em radianos, por isso tem q converter para radiano.
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            //Math.round(var, digitosDepoisDaVirgula) arredonda o valor da variavel conforme o numero de casas colocadas.
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(tangente, 4)}");
        }

        public void RaizQuadrada(double x)
        {
            //sqrt é abreviação de square root
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é {raiz}");
        }


    }
}