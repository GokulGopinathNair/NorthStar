using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternMethod
{
    interface ICalculate
    {
        public void Calculate(int a, int b);


    }

    public class Add : ICalculate
    {
        public void Calculate(int a, int b)
        {
            Console.WriteLine("Added {0}", a + b);
        }
    }

    public class Subtract : ICalculate
    {
        public void Calculate(int a, int b)
        {
            Console.WriteLine("Subtracted {0}", a - b);
        }
    }

    public class Multiply : ICalculate
    {
        public void Calculate(int a, int b)
        {
            Console.WriteLine("Multiplied {0}", a * b);
        }
    }

    public class Divide : ICalculate
    {
        public void Calculate(int a, int b)
        {
            Console.WriteLine("Divided {0}", a / b);
        }
    }
}
