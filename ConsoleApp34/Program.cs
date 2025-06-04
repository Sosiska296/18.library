using CalculationLib.dll;
using System;
class Program
{
    static void Main(string[] args)
    {
        {
            Console.WriteLine($"Plus: {Class1.Plus(12, 18)}");
            Console.WriteLine($"Minus: {Class1.Minus(777, 100)}");
            Console.WriteLine($"Multiply: {Class1.Multiply(56, 36)}");
            Console.WriteLine($"Divide: {Class1.Divide(404, 228)}");


        }
    }
}