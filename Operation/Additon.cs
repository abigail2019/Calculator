using System;

namespace Operation
{
    public class Addition
    {
        public static int Sum(int a ,int b)
        {
            return a + b;
        }
        public static double Sum(double c, double d)
        {
            return c + d;
        }
        public static double Sum(double[] ArrayB)
        {
            double c = 0.0;
            foreach (double a in ArrayB)
            {
                c = Sum(a, c);
            }
            return c;
        }
        public static int Sum(int[] ArrayA)
        {
            int c = 0;
            foreach (int a in ArrayA)
            {
                c = Sum(a, c);
            }
            return c;
        }
        //public static int Division(int a, int b)
        //{
        //    return a / b;
        //}

        //public static double Division(double c, double d)
        //{
        //    return c / d;
        //}
    }
}
