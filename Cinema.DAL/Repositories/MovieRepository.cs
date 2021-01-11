using Cinema.Domain.Interfaces;
using Cinema.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Linq;

namespace Cinema.DAL.Repositories
{
    public class MovieRepository : BaseRepository, IMovieRepository
    {
        public MovieRepository(IDbTransaction transaction) : base(transaction)
        {

        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            return await Connection.QueryAsync<Movie>(
                "SELECT * FROM Movies",
                transaction: Transaction
                );
        }

        public Task<Movie> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Movie model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Movie model)
        {
            throw new NotImplementedException();
        }
    }
}
