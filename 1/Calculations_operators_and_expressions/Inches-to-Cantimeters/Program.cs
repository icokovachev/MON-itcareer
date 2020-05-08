using System;

namespace Inches_to_Cantimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inches = ");
            double inches = double.Parse(Console.ReadLine());
            Console.WriteLine("Cantimeters = " + inches * 2.54 );
        }
    }
}
