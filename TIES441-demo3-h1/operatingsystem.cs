using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIES441_demo3_h1
{
    class operatingsystem
    {
        
        public Byte[] networkdata = Encoding.ASCII.GetBytes("kilpikonna");

        public void sendData(Byte[] s_data)
        {
            INetwork network = new Network();
            network.openConnection();
        }

        public void sendData()
        {
            //Console.WriteLine("Sent data: {0}", networkdata.ToString());
            INetwork network = new Network();
            network.openConnection();
            network.sendData(networkdata);
            network.closeConnection();
        }

        public void receiveData()
        {
            //Console.WriteLine("Received data -dummy-");
            INetwork network = new Network();
            network.openConnection();
            networkdata = network.receiveData();
            System.Text.ASCIIEncoding os_encoding = new System.Text.ASCIIEncoding();
            Console.WriteLine("OS Received data from network: type = {0}, length = {1} and value = {2}", 
                networkdata, networkdata.Length, os_encoding.GetString(networkdata));
            network.closeConnection();
        }
    }
}
