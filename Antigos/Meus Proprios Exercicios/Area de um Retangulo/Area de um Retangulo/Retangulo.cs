using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Area_de_um_Retangulo
{
    internal class Retangulo
    {
        //solução do site
        public Retangulo()
        {
            this.Base = 0;
            this.Altura = 0;
        }

        private double baseRet;

        public double Base
        {
            get { return baseRet; }
            set { 
                if (value >= 0) baseRet = value;
                else baseRet = 0;
            }
        }

        private double altRet;

        public double Altura
        {
            get { return altRet; }
            set { 
                if(value >= 0) altRet = value;
                else altRet = 0;
            }
        }

        public double Area
        {
            get { return baseRet*altRet; }
        }

        public void ExibirDados()
        {
            Console.WriteLine("Base: " + this.baseRet);
            Console.WriteLine("Altura: " + this.altRet);
            Console.WriteLine("Area: " + this.Area);
        }


        /*
         
        //minha tentativa

        public double baseRetangulo;
        public double alturaRetangulo;
        private double areaRetangulo;

        private void retanguloOuQuadrado(double baseRetangulo, double alturaRetangulo)
        {
            if(baseRetangulo == alturaRetangulo)
            {
                Console.WriteLine("O objeto é um quadrado!");
            }
            else
            {
                Console.WriteLine("O objeto é um retangulo!");
            }
        }
        private void calcArea(double baseRetangulo, double alturaRetangulo)
        {
            areaRetangulo = baseRetangulo * alturaRetangulo;
        }


        public void mensagem(double baseRetangulo, double alturaRetangulo)
        {
            retanguloOuQuadrado(baseRetangulo, alturaRetangulo);
            calcArea(baseRetangulo, alturaRetangulo);
            Console.WriteLine("E sua area é: " + this.areaRetangulo);

        }
        */

    }
}
