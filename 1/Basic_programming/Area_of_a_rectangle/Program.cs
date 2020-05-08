using System;

namespace Area_of_a_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());
            decimal result = a * b;
            Console.WriteLine(result);
        }
    }
}
