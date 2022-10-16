using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04ExercicioIMC
{
    internal class Pessoa
    {

        // Atributos
        public double peso, altura;


        // Obter calculo IMC
        public double calcularIMC()
        {
            return peso / (altura * altura);
        }


        // Obter situação
        public string situacaoIMC(double imc)
        {
            if(imc < 18.5)
            {
                return "Abaixo do peso";
            }
            else if (imc < 25)
            {
                return "Peso normal";
            }
            else if(imc < 30)
            {
                return "Acima do peso";
            }
            else if(imc < 35)
            {
                return "Obesidade I";
            }
            else if(imc < 40)
            {
                return "Obesidade II";
            }
            else{
                return "Obesidade III";
            }

        }


        // Exibir mensagem
        public void mensagem()
        {
            
            // Obter IMC
            double resultadoIMC = calcularIMC();

            // Obter situação
            string situacao = situacaoIMC(resultadoIMC);
            
            // Exibir Mensagens
            Console.WriteLine("Seu imc é de " + resultadoIMC);
            Console.WriteLine("Sua situação é " + situacao + ".");

        }






    }
}
