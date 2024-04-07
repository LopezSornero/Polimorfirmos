using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_y_Diametro
{
    internal class Circulo : Figura
    {
        private double RadioCirculo;

        public Circulo(double radioCirculo)
        {
            RadioCirculo = radioCirculo;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(RadioCirculo, 2);
        }

        public override double CalcularDiametro()
        {
            return 2 * RadioCirculo;
        }

        public override string ToString()
        {
            return $"Círculo: \nÁrea: {CalcularArea()} \nDiámetro: {CalcularDiametro()}\n";
        }
    }
}
