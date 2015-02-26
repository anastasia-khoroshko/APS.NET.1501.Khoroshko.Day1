using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqrtNPower
{
    public static class NPowerRoot
    {
        public static double MethodNewton(double number, int power, double accurancy)
        {
            double tempAccurancy = 1.0, tempX = 0, x = 1.0;
            if (number < 0) return double.NaN;
            else
            {
                while (tempAccurancy > accurancy)
                {
                    tempX = ((power - 1) * x + number / Math.Pow(x, power - 1)) / power;
                    tempAccurancy = Math.Abs(x - tempX);
                    x = tempX;
                }
                return x;
            }
        }

        public static double StantardMethod(double number, int power)
        {
            return Math.Pow(number, Math.Pow(power, -1));
        }
    }
}
