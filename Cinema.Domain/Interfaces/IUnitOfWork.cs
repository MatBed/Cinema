using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ITicketRepository Tickets { get; }
        IMovieRepository Movies { get; }
    }
}
