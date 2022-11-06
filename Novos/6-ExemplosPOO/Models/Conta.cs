using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    //(Classe Abstratas)
    //abstract significa que ela só pode ser herdada, não pode ser instanciada
    public abstract class Conta
    {
        protected decimal saldo;

        //um metodo abstrato significa que ele tem que ser implementado
        //obrigatoriamente na classe que essa classe abstrata for herdada.
        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo: R${saldo}");
        }
    }
}