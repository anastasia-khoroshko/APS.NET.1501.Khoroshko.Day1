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

        public static int [][] IncreaseSort(int[][] array, ComparisonArray ca)
        {
            for(int i=0;i<array.Length;i++)
            {
                for(int j=i;j<array.Length;j++)
                {
                    if(ca(array[i],array[j])==1)
                    {
                        int[] temp=new int[array[i].Length];
                        array[i].CopyTo(temp,0);
                        array[i] = new int[array[j].Length];
                        array[j].CopyTo(array[i], 0);
                        array[j] = new int[temp.Length];
                        temp.CopyTo(array[j], 0);
                    }
                }
            }
            return array;
        }

        public static  int[][] DecreaseSort(int[][] array, ComparisonArray ca)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (ca(array[i], array[j]) == -1)
                    {
                        int[] temp = new int[array[i].Length];
                        array[i].CopyTo(temp, 0);
                        array[i] = new int[array[j].Length];
                        array[j].CopyTo(array[i], 0);
                        array[j] = new int[temp.Length];
                        temp.CopyTo(array[j], 0);
                    }
                }
            }
            return array;
        }
        public static int CompareSum(int[] x,int[] y)
        {
            if (x.Select(s => s).Sum() > y.Select(s => s).Sum())
                return 1;
            else if (x.Select(s => s).Sum() < y.Select(s => s).Sum())
                return -1;
            else return 0;
        }


        public static int CompareMinElement(int[] x, int[] y)
        {
            if (x.Select(s => s).Min() > y.Select(s => s).Min())
                return 1;
            else if (x.Select(s => s).Min() < y.Select(s => s).Min())
                return -1;
            else return 0;
        }

        public static int CompareMaxElement(int[] x, int[] y)
        {
            if (x.Select(s => s).Max() > y.Select(s => s).Max())
                return 1;
            else if (x.Select(s => s).Max() < y.Select(s => s).Max())
                return -1;
            else return 0;
        }

    }
}
