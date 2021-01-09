using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Models
{
    public class Ticket : Entity
    {
        public Guid TicketId { get; set; }
        public Guid MovieId { get; set; }
        public double Price { get; set; }
        public int HallNumber { get; set; }
        public Seat Seat { get; set; }
    }
}
