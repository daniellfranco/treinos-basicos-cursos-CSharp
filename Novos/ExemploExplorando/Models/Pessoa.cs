using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        private string _nome;


        public string Nome
        {
            get //tratando o get
            {
                return _nome.ToUpper(); //retorna o nome em maiusculo
            }

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
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }


    }
}