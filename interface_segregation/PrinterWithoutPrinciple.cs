using System;

namespace interface_segregation
{
    public interface IPrinterTasks
    {
        void Print(string content);
        void Scan(string content);
        void Fax(string content);
        void PrintDuplex(string content);
    }
    public class HPLaserPrinter : IPrinterTasks
    {
        public void Fax(string content)
        {
            Console.WriteLine(content);
        }

        public void Print(string content)
        {
            Console.WriteLine(content);
        }

        public void PrintDuplex(string content)
        {
            Console.WriteLine(content);
        }

        public void Scan(string content)
        {
            Console.WriteLine(content);
        }
    }
    public class LiquidInkJetPrinter : IPrinterTasks
    {
        public void Fax(string content)
        {
            throw new NotImplementedException();
        }

        public void Print(string content)
        {
            Console.WriteLine(content);
        }

        public void PrintDuplex(string content)
        {
            throw new NotImplementedException();
        }

        public void Scan(string content)
        {
            Console.WriteLine(content);
        }
    }
}
