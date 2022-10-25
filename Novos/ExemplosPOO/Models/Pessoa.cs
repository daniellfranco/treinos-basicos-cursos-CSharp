using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplosPOO.Models
{
    public class Pessoa
    {
        //(herança) quando você coloca um construtor numa classe pai
        //as classes filhos acusam erro e você obrigatoriamente terá que 
        //implementar um construtor lá, verifique classes Aluno e Professor.
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        //se quiser facilitar um construtor nas classes filho é necessario colocar
        //um construtor vazio aqui e nas classe filho que você quiser também
        //exemplo: na classe aluno tem um construtor vazio e na classe professor não
        public Pessoa()
        {
        }

        public string Nome { get; set; }
        public int Idade { get; set; }


        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e minha idade é {Idade}");
        }



    }
}