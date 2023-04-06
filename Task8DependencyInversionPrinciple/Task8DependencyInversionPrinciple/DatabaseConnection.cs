using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8DependencyInversionPrinciple
{
    public interface IDatabaseConnection
    {
        void Connect();
        void Disconnect();
    }

    public class SqlConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("Sql bağlantısı sağlandı");
        }

        public void Disconnect()
        {
            Console.WriteLine("Sql bağlantısı kapatıldı");
        }
    }

    public class MongoDbConnection : IDatabaseConnection
    {
        public void Connect()
        {
            Console.WriteLine("MongoDb bağlantısı sağlandı");
        }

        public void Disconnect()
        {
            Console.WriteLine("MongoDb bağlantısı kapatıldı");
        }
    }

    //...

}
