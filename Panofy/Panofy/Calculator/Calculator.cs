﻿using System;

namespace UtilityKnife.Calculator
{
    public class Calculator
    {
        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static double Subtraction(double x, double y)
        {
            return x - y;
        }

        public static double Multiply(double x, double y)
        {
            return x * y;
        }

        public static int IntDivision(int x, int y)
        {
            return x / y;
        }

        public static double Division(double x, double y)
        {
            return x / y;
        }

        public static double DivisionTest(double x, double y)
        {
            return x / y;
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }
    }
}
