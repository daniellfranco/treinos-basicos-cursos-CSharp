using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemplosPOO.Interfaces;

namespace ExemplosPOO.Models
{
    //(Interfaces) Calculadora IMPLEMENTA a interface ICalculadora
    //apesar de ser atribuido da mesma forma que herança, é errado dizer que herda
    //pois são conceitos diferentes.
    //A interface serve para te forçar a implementar os metodos que ela contém.
    public class Calculadora : ICalculadora
    {
        //metodos vindo da interface são sempre publicos.
        public double dividir(double num1, double num2)
        {
            return num1 / num2;
        }

        public double multiplicar(double num1, double num2)
        {
            return num1 * num2;
        }

        public double somar(double num1, double num2)
        {
            return num1 + num2;
        }

        public double subtrair(double num1, double num2)
        {
            return num1 - num2;
        }
    }
}