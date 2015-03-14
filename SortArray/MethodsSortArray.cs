using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    public static class MethodsSortArray
    {
        public delegate int ComparisonArray(int[] x, int[] y);

        public static void Sort(int[][] array, ComparisonArray ca)
        {
            if (array == null || ca == null) throw new ArgumentNullException("Invalid arguments");
            for(int i=0;i<array.Length;i++)
            {
                for(int j=i;j<array.Length;j++)
                {
                    if(ca(array[i],array[j])>0)
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        private static void Swap(ref int[] x,ref int[] y)
        {
            int[] temp = x;
            x = y;
            y = temp;
        }
    }
}
