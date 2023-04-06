using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8DependencyInversionPrinciple
{
    public class User
    {
        private readonly IDatabaseConnection _databaseConnection;

        public User(IDatabaseConnection databaseConnection)
        {
            _databaseConnection = databaseConnection;
        }

        public void Register()
        {
            Console.WriteLine("_databaseConnection kullanarak kayıt olundu.");
        }

        public void Login()
        {
            Console.WriteLine("_databaseConnection kullanarak login olundu.");
        }
    }
}
