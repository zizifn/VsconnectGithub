using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UseShareMemory.ShareMemory;


namespace UseShareMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            UseShareMemory.ShareMemory.Service1Client s = new UseShareMemory.ShareMemory.Service1Client();
            ServiceReference1.Service1Client ss = new ServiceReference1.Service1Client();
            
            string str=s.GetData(2);
            Console.Write(str);
            string str1 = ss.GetData1(2);
            Console.Write(str1);
            Console.Read();
        }
    }
}
