using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposEspeciais.Models
{
    //essa é uma classe generica, ela vai receber o valor
    //do tipo que você disser para ela usar
    //na hora que voce instanciar ela.

    //esse T representa um tipo generico
    //pois ele não me diz oque é, ele só vai ser algo
    //na hora que instanciar ele no tipo que você deseja
    internal class MeuArray<T>
    {
        private static int capacidade = 10;
        private int contador = 0;

        //não é definido se o T é int string ou oq, é apenas generico ainda.
        private T[] array = new T[capacidade];

        //eu ainda não sei oque T representa mas o metodo precisa ser do mesmo tipo do array
        public void AdicionarElementoArray(T elemento)
        {
            if(contador + 1 < 11)
            {
                array[contador] = elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

    }
}
