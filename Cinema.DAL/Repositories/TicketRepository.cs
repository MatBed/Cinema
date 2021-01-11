using Cinema.Domain.Interfaces;
using Cinema.Domain.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Repositories
{
    public class TicketRepository : BaseRepository, ITicketRepository
    {
        public TicketRepository(IDbTransaction transaction) : base(transaction)
        {

        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Ticket>> GetAllAsync()
        {
            return await Connection.QueryAsync<Ticket>(
                "SELECT * FROM Tickets",
                transaction: Transaction
                );
        }

        public Task<Ticket> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Ticket model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Ticket model)
        {
            throw new NotImplementedException();
        }
    }
}
