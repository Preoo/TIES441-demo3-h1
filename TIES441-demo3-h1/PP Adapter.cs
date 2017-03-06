using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIES441_demo3_h1
{
    class PP_Adapter : IConnection
    {
        public PP_Adapter()
        {
            Console.WriteLine("Init PP_Adapter");
        }

        public void closeConnection()
        {
            Console.WriteLine("Init PP_Adapter");
        }

        public void openConnection()
        {
            Console.WriteLine("Init PP_Adapter");
        }

        public byte[] receiveData()
        {
            Byte[] temp = new Byte[1];
            return temp;
        }

        public void sendData(byte[] s_data)
        {
            Console.WriteLine("Init PP_Adapter");
        }
    }
}
