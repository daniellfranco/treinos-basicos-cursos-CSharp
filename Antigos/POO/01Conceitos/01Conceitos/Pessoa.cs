using System;

namespace _01Conceitos
{
    class Pessoa
    {
        
        //Atributos
        
        //public significa que essa variavel pode ser acessada de qualquer lugar do projeto
        public string nome;
        
        public int idade;

        //Métodos
        public void mensagem()
        {
            Console.WriteLine("Olá "+nome+" você tem "+idade+" anos.");
        }

    }

}
