
using System;

namespace ExpressionLib
{
    public class Expression
    {
        private double a, c, d;

        public Expression(double a, double c, double d)
        {
            this.a = a;
            this.c = c;
            this.d = d;
        }

        public double A => a;
        public double C => c;
        public double D => d;

        public void SetA(double value) => a = value;
        public void SetC(double value) => c = value;
        public void SetD(double value) => d = value;

        private double CalculateLog(double value)
        {
            if (value <= 0)
                throw new ArgumentException("Неможливо обчислити логарифм від нуля або від'ємного числа.");
            return Math.Log10(value);
        }

        public double Evaluate()
        {
            try
            {
                double numerator = CalculateLog(2 * c - a) + d - 152;
                double denominator = a / 4 + c;
                if (denominator == 0)
                    throw new DivideByZeroException("Ділення на нуль у знаменнику.");
                return numerator / denominator;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Помилка при обчисленні виразу: " + ex.Message);
            }
        }
    }
}
