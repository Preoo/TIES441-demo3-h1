using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIES441_demo3_h1
{
    internal class Network : INetwork
    {
        
        IConnection _connection;
        public Network ()
        {
            _connection = SetConnection();

        }
        private IConnection SetConnection()
        {
           /* Used to select connection, 
            * so operating system doesn't need to.
            * Could get connection from external 
            * source such as settings etc but for
            * demo, this is -good nuff-.
            *
            * Useful for adding new connections. */
            return new Acme();

        }

        public void closeConnection()
        {
            _connection.closeConnection();
        }

        public void openConnection()
        {
            //Console.WriteLine("Opening connection");
            _connection.openConnection();
        }

        public Byte[] receiveData()
        {
            return _connection.receiveData();
        }

        public void sendData(Byte[] s_data)
        {
            _connection.sendData(s_data);
        }
    }

    internal interface IConnection
    {
        void openConnection();
        void closeConnection();
        void sendData(Byte[] s_data);
        Byte[] receiveData();
    }

    internal class Bonc : IConnection
    {
        public Bonc()
        {
            Console.WriteLine("Bonc constructor");
        }
        public void closeConnection()
        {
            throw new NotImplementedException();
        }

        public void openConnection()
        {
            throw new NotImplementedException();
        }

        public Byte[] receiveData()
        {
            throw new NotImplementedException();
        }

        public void sendData(byte[] s_data)
        {
            throw new NotImplementedException();
        }
    }

    internal class Acme : IConnection
    {
        public Acme()
        {
            Console.WriteLine("Acme constructor");
        }
        public void closeConnection()
        {
            Console.WriteLine("Acme closeconnection");
        }

        public void openConnection()
        {
            Console.WriteLine("Acme openconnection");
        }

        public Byte[] receiveData()
        {
            return (Byte[])Encoding.ASCII.GetBytes("kissa");
        }

        public void sendData(Byte[] s_data)
        {
            Console.WriteLine("Acme sent data: {0} of length {1} and value = {2}", s_data, s_data.Length, decodeByteArray(s_data) );
        }
        string decodeByteArray (Byte[] in_data)
        {
            System.Text.ASCIIEncoding encoding = new System.Text.ASCIIEncoding();
            return encoding.GetString(in_data);
        }
    }
}