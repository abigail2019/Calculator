using System;
using System.Collections.Generic;
using System.Text;

namespace Operation
{
   public class Multiplication
    {
        public static double Multiply(double c, double d)
        {
            return c * d;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Multiply(double[] ArrayA)
        {
            double c = ArrayA[0];
            for (int d = 1; d < ArrayA.Length; d++)
            {
                c = Multiply(c, ArrayA[d]);
            }
            return c;
        }
        public static int Multiply(int[] ArrayA)
        {
            int c = ArrayA[0];
            for (int d = 1; d < ArrayA.Length; d++)
            {
                c = Multiply(c, ArrayA[d]);
            }
            return c;
        }
    }
}
