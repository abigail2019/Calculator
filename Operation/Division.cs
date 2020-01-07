using System;
using System.Collections.Generic;
using System.Text;

namespace Operation
{
    public class Division
    {
        public static int Divsion(int a, int b)
        {
            return a / b;
        }

        public static double Divsion(double c, double d)
        {
            return c / d;
        }
        public static double Divsion(double[] ArrayA)
        {
            double c = ArrayA[0];
            for(int d= 1; d<ArrayA.Length;d++)
            {
                c = Divsion(c, ArrayA[d]);
            }
            return c;
        }
        public static int Divsion(int[] ArrayB)
        {
            int c =  ArrayB[0];
            for(int i=1;i<ArrayB.Length;i++)
            {
                c = Divsion(c, ArrayB[i]);
            }

            //foreach (int a in ArrayB)
            //{
            //    c = Divsion(c, a);
            //}
            return c;
        }
    }
}
