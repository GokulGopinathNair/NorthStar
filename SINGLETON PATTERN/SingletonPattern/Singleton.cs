using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public sealed class Singleton
    {
        public static Singleton obj = null;
        private static int counter = 0;
        public static Singleton Getobjinstance
        {
            get
            {
                if(obj == null)
                {
                    obj = new Singleton();
                    counter = counter + 1;
                    Console.WriteLine("Object Instantiated " +  counter + " times" );
                }
                return obj;
            }
        }
        private Singleton()
        {

        }

        public void printmessage(string message)
        {
            Console.WriteLine("The Echo message is \"" + message + "\"");
        }

    }
}
