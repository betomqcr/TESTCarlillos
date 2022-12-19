using Datos.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Connection
{
    public class ConnectionManager : IConnectionManager
    {
        private readonly IConfiguration configuration = null;

        public static string PDR = "BloggingDatabase";
        public static string DEVCarlos = "ConnectionDevCarlos";

        public ConnectionManager(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IDbConnection GetConnection(string key)
        {
            return new SqlConnection(ConfigurationExtensions.GetConnectionString(configuration, key));
        }
    }
}
