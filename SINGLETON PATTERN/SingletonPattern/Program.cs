using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Irrespective of the number of times new object is asked to create, only once it gets instantiated.
            Singleton newobj1 = Singleton.Getobjinstance;
            Singleton newobj2 = Singleton.Getobjinstance;
            Singleton newobj3 = Singleton.Getobjinstance;
            Singleton newobj4 = Singleton.Getobjinstance;
            Console.ReadLine();
        }
    }
}
