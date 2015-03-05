using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace SqrtNPower
{
    public static class NPowerRoot
    {
        public static double MethodNewton(double number, int power, double accurancy=0.001)
        {
            double tempAccurancy = 1.0, tempX = 0, x = 1.0;
           
            if (number < 0 && power % 2 == 0 || accurancy < 0 || accurancy > 1) throw new FormatException("Invalid data!");
           
            while (tempAccurancy > accurancy)
            {
                tempX = ((power - 1) * x + number / Math.Pow(x, power - 1)) / power;
                tempAccurancy = Math.Abs(x - tempX);
                x = tempX;
            }
            return x;
        }

        public static double StantardMethod(double number, int power)
        {
            return Math.Pow(number, Math.Pow(power, -1));
        }
    }
}
