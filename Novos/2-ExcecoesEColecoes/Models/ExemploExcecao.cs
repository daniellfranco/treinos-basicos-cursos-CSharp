using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExcecoesEColecoes.Models
{
    public class ExemploExcecao
    {

        public void MetodoExcecao()
        {
            // Exceções devem ser usadas com CAUTELA, pois elas reduzem a performance do codigo e prejudicam a legibilidade
            // Devem ser usadas mais em casos de não ter muido controle do que você está recebendo.
            // Em casos mais simples como ver se um dado é vazio ou nao, é melhor usar um if mesmo.
            try
            {
                string[] linhas = File.ReadAllLines("Arquivos/arquivo-Leitura.txt");

                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }
            }
            //Pode-se ter uma ou mais excessões
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Arquivo não encontrado. {ex.Message}");
            }
            //Só pode cair em uma excessão por vez, a que for compativel com o tipo de excessão
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"Caminho da pasta não encontrado."
                                                        + ex.Message);
            }
            //Se não for compativel com nenhuma das expecificas acima, ele cai na generica.
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
            }
            //o finally sempre é executado, idependente se uma excessão ocorrer ou não.
            finally
            {
                Console.WriteLine("Chegou Aqui");
                //Pode ser util para fechar conexões, por exemplo a de banco que o banco segura ela aberta até finalizar o acesso.
                //Ou para reportar aos devs se algo foi executado ou não com sucesso por exemplo.
            }
        }





        public void MetodoExcecao2()
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
        //se ela não encontrar, o programa encerra e da o caminho do metodo 4 até o inicio,
        //no console, se ela encontrar ela cai no catch e executa oque tem la.
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma Exceção.");
        }

    }
}