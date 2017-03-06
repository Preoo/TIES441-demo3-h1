using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIES441_demo3_h1
{
    internal interface IPP_Connection
    {
        void setConnectionOpen(Boolean state);
        Byte[] communicate(Byte[] data, Boolean readFlag);
    }

    internal class PP_Connection : IPP_Connection
    {
        public PP_Connection()
        {
            Console.WriteLine("PP init");
        }

        public Byte[] communicate(byte[] data, bool readFlag)
        {
            //Byte[] buffer = new Byte[data.Length];
            if (readFlag)
            {
                //buffer = data;
                Console.WriteLine("PP Read data: {0} of length {1} and value = {2}", 
                    data, data.Length, new ASCIIEncoding().GetString(data) );
                return new Byte[0];
            }
            else
            {
                Byte[] temp = Encoding.ASCII.GetBytes("koirat haukkuu ja karavaani kulkee"); ;
                Console.WriteLine("PP Write data via Adapter");
                return temp;
            }
        }

        public void setConnectionOpen(bool state)
        {
            if (state)
            {
                Console.WriteLine("PP open connection - concrete");
            }
            else
            {
                Console.WriteLine("PP close connection - concrete");
            }
        }
    }
}
