using Donation.Core.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Donation.Dapper
{
    public class ConnectionFactory : IConnectionFactory
    {
        private readonly string connectionString;
        public ConnectionFactory(string connectionString) 
        {
            this.connectionString = connectionString;       
        }
        public IDbConnection GetConnection()
        {
            return new SqlConnection(this.connectionString);
        }
    }
}
