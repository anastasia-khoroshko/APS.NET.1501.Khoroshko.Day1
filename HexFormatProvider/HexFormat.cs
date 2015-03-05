using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexFormatProvider
{
    public class HexFormat : IFormatProvider, ICustomFormatter
    {
        private int tempNumber;
        IFormatProvider parent;
        public HexFormat()
        {
            parent = CultureInfo.CurrentCulture;
        }
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter)) return this;
            return null;
        }

        public string Format(string format, object number, IFormatProvider provider )
        {
            if (number == null || format != "h")
                return String.Format(parent, "{0:" + format + "}", number);
            if (provider == null) provider =CultureInfo.InvariantCulture;
            tempNumber =(int)number;
            return Hex().ToString(provider)+"h";
        }


        public string Hex()
        {
                string result = "";
                double temp = tempNumber;
                while (temp >= 16)
                {
                    result = ConvertToHex(temp) + result;
                    temp = Math.Floor(temp / 16);
                }

                return ConvertToHex(temp) + result;
        }

        private string ConvertToHex(double temp)
        {
            if (temp % 16 == 10)
                return "A";
            else if (temp % 16 == 11)
                return "B";
            else if (temp % 16 == 12)
                return "C";
            else if (temp % 16 == 13)
                return "D";
            else if (temp % 16 == 14)
                return "E";
            else if (temp % 16 == 15)
                return "F";
            else return (temp % 16).ToString();
        }
        //public override string ToString()
        //{
        //    return this.ToString("h", CultureInfo.CurrentCulture);
        //}

        //public string ToString(string format)
        //{
        //    return this.ToString(format, CultureInfo.CurrentCulture);
        //}

        //public string ToString(string format, IFormatProvider provider)
        //{
        //    if (String.IsNullOrEmpty(format)) format = "h";
        //    if (provider == null) provider = CultureInfo.CurrentCulture;
        //    return Hex.ToString(provider) + "h";
        //}
    }
}
