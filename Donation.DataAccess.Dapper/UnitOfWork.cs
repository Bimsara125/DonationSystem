using Donation.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donation.DataAccess.Dapper
{
    public class UnitOfWork : IUnitOfWorkAsync
    {
        private IConnectionFactory connectionFactory;

        public UnitOfWork(IConnectionFactory connectionFactory)
        {
            this.connectionFactory = connectionFactory;

        }
    }
}
