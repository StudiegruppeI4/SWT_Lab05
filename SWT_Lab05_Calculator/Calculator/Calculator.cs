using System;

namespace Lab01
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            double result = a + b;
            Accumulator = result;
            return result;
        }

        public double Subtract(double a, double b)
        {
            double result = a - b;
            Accumulator = result;
            return result;
        }

        public double Multiply(double a, double b)
        {
            double result = a * b;
            Accumulator = result;
            return result;
        }

        public double Power(double x, double exp)
        {
            double result = Math.Pow(x, exp);
            Accumulator = result;
            return result;
        }

        public double Divide(double a, double b)
        {
                if(b == 0) throw new DivideByZeroException();
                double result = a / b;
                Accumulator = result;
                return result;
        }

        //Using Accumulator
        public double Add(double a)
        {
            return Add(Accumulator,a);
        }

        public double Subtract(double a)
        {
            return Subtract(Accumulator,a);
        }

        public double Multiply(double a)
        {
            return Multiply(Accumulator,a);
        }

        public double Power(double x)
        {
            return Power(Accumulator,x);
        }

        public void Clear()
        {
            Accumulator = 0d;
        }

        public double Accumulator { get; private set; }
    }
}