using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaper
{
    internal class PointAdapter :IVector
    {
        private readonly Point _point;
        public PointAdapter(Point point)
        {
            _point=point;
        }

        public double X => _point.X;

        public double Y => _point.Y;

        public double Magnitude => Math.Sqrt(X* X + Y * Y); 
    }
}
