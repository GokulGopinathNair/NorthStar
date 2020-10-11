using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    abstract class DataProcessor
    {
        public void ReadProcessSave(string sourcetype)
        {
            ReadData();
            ProcessData();
            SaveData(sourcetype);
        }

        public abstract void ReadData();
        public abstract void ProcessData();

        public void SaveData(string sourcetype)
        {
            Console.WriteLine("Saving Processed data from {0} to Database - Common Service", sourcetype);
        }


    }

    class ExcelEngine : DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Read Data from Excel");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process Data from Excel");
        }

    }

    class TextEngine : DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Read Data from Text");
        }

        public override void ProcessData()
        {
            Console.WriteLine("Process Data from Text");
        }

    }
}
