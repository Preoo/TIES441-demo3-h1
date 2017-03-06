using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIES441_demo3_h1
{
    class PP_Adapter : IConnection
    {
        private IPP_Connection pp_con;
        public PP_Adapter()
        {
            Console.WriteLine("Init PP Adapter");
            pp_con = new PP_Connection();
        }

        public void closeConnection()
        {
            Console.WriteLine("PP Close connection via adapter");
            pp_con.setConnectionOpen(false);
        }

        public void openConnection()
        {
            Console.WriteLine("PP Open connection via adapter");
            pp_con.setConnectionOpen(true);
        }

        public byte[] receiveData()
        {
            Console.WriteLine("Adapter got data from PP");
            return pp_con.communicate(new Byte[0], false);
        }

        public void sendData(byte[] s_data)
        {
            Console.WriteLine("PP sent data via adapter");
            pp_con.communicate(s_data, true);
        }
    }
}
