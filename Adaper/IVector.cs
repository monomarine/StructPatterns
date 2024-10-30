using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaper
{
    internal interface IVector
    {
        double X { get; }
        double Y { get; } 
        double Magnitude { get; }   
    }
}
