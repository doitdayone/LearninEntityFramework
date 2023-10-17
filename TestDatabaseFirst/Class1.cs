using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDatabaseFirst
{
    class Class1
    {
        static String getConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                             .SetBasePath(Directory.GetCurrentDirectory())
                             .AddJsonFile("appsettings.json",true,true)
                             .Build();
        }
    }
}
