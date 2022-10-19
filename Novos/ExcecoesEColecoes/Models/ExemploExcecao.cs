using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcecoesEColecoes.Models
{
    public class ExemploExcecao
    {
        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exceção tratada. " + ex.Message);
            }

        }

        public void Metodo2()
        {
            Metodo3();
        }

        public void Metodo3()
        {
            Metodo4();
        }

        //quando ocorre uma exceção ela irá retornar até o inicio buscando um tryCatch
        //se ela não encontrar, o programa encerra e da o caminha do metodo 4 até o inicio,
        //no console, se ela encontrar ela cai no catch e executa oque tem la.
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma Exceção.");
        }

    }
}