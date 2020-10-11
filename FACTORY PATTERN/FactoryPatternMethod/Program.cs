using System;

namespace FactoryPatternMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int second = Convert.ToInt32(Console.ReadLine());

            CalculateFactory calcfac = new CalculateFactory();
            ICalculate obj = calcfac.execute();
            obj.Calculate(first,second);
            Console.ReadLine();
        }
    }
}
