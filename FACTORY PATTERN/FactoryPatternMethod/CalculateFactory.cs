using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternMethod
{
    class CalculateFactory
    {
        public ICalculate execute()
        {
            ICalculate calc = null;
            Console.WriteLine("Select the operation 1 - To Add, 2 - To Multiply, 3 - To Divide, 4 - To Subtract");
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    calc = new Add();
                    break;
                case 2:
                    calc = new Multiply();
                    break;
                case 3:
                    calc = new Divide();
                    break;
                case 4:
                    calc = new Subtract();
                    break;
            }
            return calc;
        }
    }
}
