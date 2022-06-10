using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1Retangulo
{
    internal class Retangulo
    {

        public double Largura { get; set; }
        public double Altura { get; set; }


        //o construtor dos dados dentro da classe, recebe os parametros do programa principal e atribui aos atributos da classe
        public Retangulo(double largura, double altura)
        {
            Largura = largura;
            Altura = altura;
        }


        //metodo que vai calcular e me retornar a area do retangulo
        public double Area()
        {
            return Altura * Largura;
            
        }


        //metodo que vai calcular e me retornar o perimetro do retangulo
        public double Perimetro()
        {
            return 2 * (Largura + Altura);
            
        }


        //metodo que vai calcular e me retornar a diagonal do retangulo
        public double Diagonal()
        {
            return Math.Sqrt((Largura * Largura) + (Altura * Altura));
            
        }

        //override é uma impressão padrão
        public override string ToString()
        {
            return 
                    "Area do retângulo "
                   + Area() + "\n"
                   + "Perimetro do retângulo "
                   + Perimetro() + "\n"
                   + "Diagonal do retângulo "
                   + Diagonal() + "\n";
                   
        }

    }
}
