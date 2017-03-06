using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIES441_demo3_h1
{
    class Program
    {
        static void Main(string[] args)
        {
            operatingsystem os = new operatingsystem();
            os.sendData();
            Console.WriteLine("--------------------");
            os.receiveData();
            Console.ReadKey();
        }
    }
}
