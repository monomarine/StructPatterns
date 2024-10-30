using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaper
{
    internal class Vector : IVector
    {
        public double X { get; private set; }

        public double Y { get; private set; }

        public double Magnitude => Math.Sqrt(X*X + Y*Y);

        public Vector(double x, double y)
        {
            X=x;
            Y=y;
        }
    }
}
