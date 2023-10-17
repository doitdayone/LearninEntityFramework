using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDataBase
{
    class Program
    {
        static string getConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                                              .AddJsonFile("appsettings.json",true,true).Build();
            var strConnection = config["ConnectionStrings:MyStoreDB"];
            return strConnection;
        }
        static void ViewProducts()
        {
            DbProviderFactory factory = SqlClientFactory.Instance;
            using DbConnection connection = factory.CreateConnection(); 
            if (connection == null )
            {
                Console.WriteLine($"Unable to create the connection object.");
                return;
            }
            connection.ConnectionString = getConnectionString();
            connection.Open();
            DbCommand command = connection.CreateCommand();
            if ( command == null )
            {
                Console.WriteLine($"Unable to create the command object.");
                return;
            }
            command.Connection = connection;
            command.CommandText = "Select ProductID, ProductName From Products";

            using DbDataReader dataReader = command.ExecuteReader();
            while(dataReader.Read())
            {
                Console.WriteLine($"ProductID: {dataReader["ProductID"]} " +
                    $"ProductName: {dataReader["ProductName"]}");
            }
            
        }
        static void Main(string[] args)
            {
                ViewProducts();
                Console.ReadLine();
            }
    }
}
