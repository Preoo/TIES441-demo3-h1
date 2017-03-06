using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIES441_demo3_h1
{
    class PP_Adapter : IConnection
    {
        public void closeConnection()
        {
            throw new NotImplementedException();
        }

        public void openConnection()
        {
            throw new NotImplementedException();
        }

        public byte[] receiveData()
        {
            throw new NotImplementedException();
        }

        public void sendData(byte[] s_data)
        {
            throw new NotImplementedException();
        }
    }
}
