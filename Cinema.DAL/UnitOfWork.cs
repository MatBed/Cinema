using Cinema.DAL.Repositories;
using Cinema.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Cinema.DAL
{
    class UnitOfWork : IUnitOfWork
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;

        private ITicketRepository _tickets;
        private IMovieRepository _movies;

        public UnitOfWork(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
            _connection.Open();
            _transaction = _connection.BeginTransaction();
        }

        public ITicketRepository Tickets { get { return _tickets ?? (_tickets = new TicketRepository(_transaction)); } }
        public IMovieRepository Movies { get { return _movies ?? (_movies = new MovieRepository(_transaction));  } }
    }
}
