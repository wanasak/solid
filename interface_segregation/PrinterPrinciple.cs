using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_segregation
{
    public interface IPrinter
    {
        void Print(string content);
        void Scan(string content);
    }
    public interface IFax
    {
        void Fax(string content);
    }
    public interface IPrintDuplex
    {
        void PrintDuplex(string content);
    }
    public class HPLaser : IPrinter, IFax, IPrintDuplex
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
    public class LiquidInkJet : IPrinter
    {
        public void Print(string content)
        {
            Console.WriteLine(content);
        }

        public void Scan(string content)
        {
            Console.WriteLine(content);
        }
    }
}
