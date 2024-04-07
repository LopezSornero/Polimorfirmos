using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_y_Diametro
{
    public abstract class Figura
    {
        public abstract double CalcularArea();
        public abstract double CalcularDiametro();

        public override string ToString()
        {
            return "Figura";
        }
    }
}
