using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloMethod
{
    class Calculations
    {
        public double GetHypotenuse(Coordinates coordinates)
        {
            double hypotenuse;
            hypotenuse = Math.Sqrt((coordinates.x * coordinates.x) + (coordinates.y * coordinates.y));
            return hypotenuse;
        }

    }
}
