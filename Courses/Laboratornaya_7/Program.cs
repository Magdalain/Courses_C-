using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratornaya_7
{
    internal class Program

    {
        public static (double a1, double a2, bool hasRoots, bool hasOneRoot) EquationSolver(double a, double b, double c)
        {
            if (a ==0)
            {
                throw new ArgumentException("a не должно быть = 0");
            }
            double disc = b * b - 4 * a * c;
            if (disc < 0d)
                return (0d, 0d, false, false);
            else
            {
                if (disc == 0d)
                {
                    double x = -b / (2 * a);
                    return (x, x, true, true);
                }
                else
                {
                    double y = Math.Sqrt(disc);
                    double x1 = (-b + y) / (2 * a);
                    double x2 = (-b - y) / (2 * a);
                    return (x1, x2, true, false);
                }
            }

        }
        static void Main(string[] args)
        {
             


        }
    }
}