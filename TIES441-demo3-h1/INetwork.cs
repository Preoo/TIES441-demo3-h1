using System;

namespace TIES441_demo3_h1
{
    internal interface INetwork
    {
        void openConnection();
        void closeConnection();
        void sendData(Byte[] s_data);
        Byte[] receiveData();
    }
}