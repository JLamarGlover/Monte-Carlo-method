using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloMethod
{
    public struct Coordinates
    {
        public double x, y;
        public Coordinates(Random random)
        {
            x = random.NextDouble();
            y = random.NextDouble();
        }
        public Coordinates(double xx, double yy)
        {
            x = xx;
            y = yy;
        }
    }
}
