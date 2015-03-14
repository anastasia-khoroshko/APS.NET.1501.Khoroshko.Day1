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
            bool supporFormat = false;
            if (string.Compare(format, "h") == 0) supporFormat = true;
            else if (string.Compare(format, "H") == 0) supporFormat = true;
            if (number == null || !supporFormat)
                return String.Format(parent, "{0:" + format + "}", number);
            if (provider == null) provider =CultureInfo.InvariantCulture;
            try
            {
                tempNumber = (int)number;
            }
            catch(InvalidCastException ex)
            {
                throw;
            }
            return Hex().ToString(provider)+"h";
        }


        private string Hex()
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
       
    }
}
