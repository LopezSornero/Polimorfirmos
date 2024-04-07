using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_y_Diametro
{
    internal class Cuadrado : Figura
    {
        private double LadoCuadrado;

        public Cuadrado(double ladoCuadrado)
        {
            LadoCuadrado = ladoCuadrado;
        }

        public override double CalcularArea()
        {
            return Math.Pow(LadoCuadrado, 2);
        }

        public override double CalcularDiametro()
        {
            return LadoCuadrado * Math.Sqrt(2);
        }

        public override string ToString()
        {
            return $"Cuadrado: \nÁrea: {CalcularArea()} \nDiámetro: {CalcularDiametro()}\n";
        }
    }
}
