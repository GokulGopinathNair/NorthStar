using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection_Employee
{
    interface IEmail
    {
        public void SendEmail(string name);

    }

    public class OutlookEmail : IEmail
    {
        public void SendEmail(string name)
        {
            Console.WriteLine("Sending mail to {0} using Outlook - Implementation",name);
        }
    }

    public class ShellEmail : IEmail
    {
        public void SendEmail(string name)
        {
            Console.WriteLine("Sending mail to {0} using Shell - Implementation",name);
        }
    }


    public class WebEmail : IEmail
    {
        public void SendEmail(string name)
        {
            Console.WriteLine("Sending mail to {0} using Web - Implementation", name);
        }
    }
}
