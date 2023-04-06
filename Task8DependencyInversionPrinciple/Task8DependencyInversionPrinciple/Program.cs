// See https://aka.ms/new-console-template for more information
using Task8DependencyInversionPrinciple;


SqlConnection sqlConnection = new SqlConnection();
sqlConnection.Connect();

User user = new User(sqlConnection);
user.Register();
user.Login();

sqlConnection.Disconnect();



MongoDbConnection mongoDbConnection = new MongoDbConnection();
mongoDbConnection.Connect();

User user2 = new User(mongoDbConnection);
user2.Register();
user2.Login();

mongoDbConnection.Disconnect();