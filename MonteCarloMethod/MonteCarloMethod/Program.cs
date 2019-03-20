using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteCarloMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number of coordinates you would like for Monte Carlo to test");
            int z;
            double ctr = 0;
            double PiEstimate;
            int.TryParse(Console.ReadLine(), out z);
            double[] Coordinates = new double[z];
            Calculations calculate = new Calculations();
            Random random = new Random();

            for (int i = 0; i < Coordinates.Length; i++)
            {
                Coordinates coordinates = new Coordinates(random);
                Coordinates[i] = calculate.GetHypotenuse(coordinates);
                if (Coordinates[i] <= 1)
                {
                    ctr++;
                }
            }
            PiEstimate = (ctr / (double) Coordinates.Length * 4);
            Console.WriteLine($"{PiEstimate}");
            Console.ReadKey();
        }
    }
}
