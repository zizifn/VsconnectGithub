using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write(DateTime.Now.Date.ToShortDateString());
           Console.Read();
        }
    }
}
