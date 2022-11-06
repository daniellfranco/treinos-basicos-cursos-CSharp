using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        //construtor basico
        public Pessoa() { }

        //construtor que ja adiciona os dados
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }



        private string _nome; //private só pode ser acessado pela classe.
        private int _idade;

        public string Nome
        {
            //tratando o get
            //quando o tratamento é muito simples, o ideal é usar essa forma para simplificar.
            get => _nome.ToUpper(); //retorna o nome em maiusculo


            set //tratando o set
            {
                if (value == "")
                {
                    //throw encerra o codigo como um erro.
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public string Sobrenome { get; set; }

        //essa propriedade é somente get, e ela automaticamente recebe nome e sobrenome concatenado.
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade
        {
            get => _idade;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor do que zero");
                }
                _idade = value;
            }
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }


    }
}