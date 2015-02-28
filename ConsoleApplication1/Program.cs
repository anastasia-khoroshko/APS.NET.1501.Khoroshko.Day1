using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HexFormatProvider.HexFormat number = new HexFormatProvider.HexFormat(46877);           
            string res=String.Format(number.ToString("h"));
        }
    }
}
