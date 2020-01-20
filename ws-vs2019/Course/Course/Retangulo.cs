using System;
using System.Collections.Generic;
using System.Text;

namespace Course
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return (Largura * Altura) / 2;
        }

        public double Perimetro()
        {
            return (Largura + Altura) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return "AREA: " 
                    + Area() 
                    + ", " 
                    + "PERIMETRO: " 
                    + Perimetro() 
                    + ", " 
                    + "DIAGONAL: " 
                    + Diagonal();
        }
    }
}
