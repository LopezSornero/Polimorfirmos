using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_y_Diametro
{
    internal class Triangulo : Figura
    {
        private double BaseTriangulo;
        private double AlturaTriangulo;

        public Triangulo(double baseTriangulo, double alturaTriangulo)
        {
            BaseTriangulo = baseTriangulo;
            AlturaTriangulo = alturaTriangulo;
        }

        public override double CalcularArea()
        {
            return (BaseTriangulo * AlturaTriangulo)/2;
        }

        public override double CalcularDiametro()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"Triángulo: \nÁrea: {CalcularArea()}\n";
        }
    }
}
