using System;

namespace Celsius_to_Fahrenheit_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = celsius * 1.8 + 23;
            Console.WriteLine("F = " + (celsius * 1.8) + 32);
        }
    }
}
