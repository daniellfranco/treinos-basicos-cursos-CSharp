using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparação_Arrays_Console
{
    internal class Comparacao
    {

        public int[] meuJogoDaMega = { 0, 0, 0, 0, 0, 0 };
        public int[] resultadoDaMega = { 0, 0, 0, 0, 0, 0};
        int contador = 0;
        public bool continuar = false;

        public void comparacao()
        {
            for (int i = 0; i < meuJogoDaMega.Length; i++)
            {
                for (int j = 0; j < meuJogoDaMega.Length; j++)
                {
                    if (resultadoDaMega[j] == meuJogoDaMega[i])
                    {
                        contador++;
                        break;

                    }
                }
            }

            Console.WriteLine("Total de numeros repetidos -> " + contador);
        }


        public void repetir()
        {
            Console.WriteLine("Deseja testar outro jogo com o mesmo resultado? s = sim, n = não");
            string sn = Console.ReadLine();
            if (sn == "s")
            {
                continuar = true;
                contador = 0;
                Console.Clear();
            }
            else if (sn == "n")
            {
                continuar = false;
                Console.WriteLine("Programa encerrado, precione enter novamente para fechar.");
            }
            else
            {
                Console.WriteLine("letra ou comando desconhecido");
                repetir();
            }
        }

        




    }
}
