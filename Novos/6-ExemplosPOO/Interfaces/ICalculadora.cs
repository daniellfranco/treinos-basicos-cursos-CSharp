using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Interfaces
{
    public interface ICalculadora
    {
        //não tem public private etc, pois por padrão subentende-se que são publicas
        double somar(double num1, double num2);
        double subtrair(double num1, double num2);
        double dividir(double num1, double num2);
        double multiplicar(double num1, double num2);
    }
}