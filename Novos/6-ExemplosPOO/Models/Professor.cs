using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    //(herança) com o : faz Professor herdar Pessoa
    //(herança) com o sealed impede que outra classe herde essa classe
    public sealed class Professor : Pessoa
    {
        //(herança) como foi criado um construtor na classe pai
        //essa classe filho exige que tenha um construtor também
        //e ele pode ser dessa forma, sem nada dentro
        //isso significa que a string nome está sendo passada para
        // a string nome da sua classe base (ou seja sua classe pai)
        public Professor(string nome) : base(nome)
        {
        }

        public decimal Salario { get; set; }

        //(Polimorfismo) override serve para sobrescrever o metodo vindo de pessoa
        //(Herança) sealed significa que a classe que herdar esta não vai conseguir alterar esse metodo
        //pois ele está selado, nesse caso a classe professor também está selada então não pode ser herdada,
        //mas se não tivesse e pudesse, esse metodo não poderia ser alterado.
        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, sou professor(a) e meu salario é R${Salario}.");
        }
    }
}