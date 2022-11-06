using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    //(herança) com o : faz Aluno herdar Pessoa
    public class Aluno : Pessoa
    {
        //(herança) como foi criado um construtor na classe pai
        //essa classe filho exige que tenha um construtor também
        //e ele pode ser dessa forma, sem nada dentro
        //isso significa que a string nome está sendo passada para
        // a string nome da sua classe base (ou seja sua classe pai)
        public Aluno(string nome) : base(nome)
        {
        }

        public Aluno()
        {
        }

        public int Nota { get; set; }

        //(Polimorfismo) override serve para sobrescrever o metodo vindo de pessoa.
        //(Herança) sealed significa que a classe que herdar esta não vai conseguir alterar esse metodo
        //pois ele está selado.
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} ano e sou aluno(a) nota {Nota}.");
        }
    }
}