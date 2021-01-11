using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Cinema.DAL.Repositories
{
    public abstract class BaseRepository
    {
        public IDbConnection Connection { get { return Transaction.Connection; } }
        public IDbTransaction Transaction { get; set; }

        public BaseRepository(IDbTransaction transaction)
        {
            Transaction = transaction;
        }
    }
}
