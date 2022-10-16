using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10Herança
{
    // para colaborador herdar o conteudo de Pessoa (tipo variaveis)
    // tem q por 2 pontos e o nome da classe pessoa.
    internal class Colaborador : Pessoa
    {
        // Construtor
        public Colaborador(string nome, int idade, string genero, double salario)
        {
            this.nome = nome;  
            this.idade = idade;
            this.salario = salario;
            this.genero = genero;

            mensagemPessoa();
            mensagemColaborador();
            testeMensagem();
        }
        
        // Atributos
        private double salario;

        private void mensagemColaborador()
        {
            Console.WriteLine("Salario: " + salario);
        }
    }
}
