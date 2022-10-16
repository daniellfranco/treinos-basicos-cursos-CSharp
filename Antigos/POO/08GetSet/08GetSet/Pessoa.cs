using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08GetSet
{
    internal class Pessoa
    {
        // Atributo nome

        private string nome;

        // Get e Set

        public string Nome
        {
            //Pode ter só um ou outro conforme a necessidade
            
            //Get é só leitura
            get { return nome; }

            //Set é só escrever
            set { nome = value; }
        }

    }
}
