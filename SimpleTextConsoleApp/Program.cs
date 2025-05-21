
using System;
using ExpressionLib;

class Program
{
    static void Main()
    {
        Expression[] expressions = new Expression[]
        {
            new Expression(4, 3, 10),
            new Expression(1, 1, 0),
            new Expression(10, 20, -10),
            new Expression(6, 3, 152)
        };

        foreach (var expr in expressions)
        {
            try
            {
                double result = expr.Evaluate();
                Console.WriteLine($"Результат для a={expr.A}, c={expr.C}, d={expr.D} => {result:F4}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка для a={expr.A}, c={expr.C}, d={expr.D}: {ex.Message}");
            }
        }
    }
}
