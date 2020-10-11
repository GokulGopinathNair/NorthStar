using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Template Method Pattern shows how to avoid duplicate methods eventhough its part of the same process and to incorporate separate code as methods eventhough they are part of the same process");
            DataProcessor obj = new ExcelEngine();
            obj.ReadProcessSave("Excel");
            DataProcessor obj1 = new TextEngine();
            obj1.ReadProcessSave("Text");

            Console.ReadLine();
        }
    }
}
