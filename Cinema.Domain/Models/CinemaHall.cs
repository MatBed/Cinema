using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Models
{
    public class CinemaHall : Entity
    {
        public int Number { get; set; }
        public HallType Type { get; set; }

        public ISet<Seat> Seats { get; set; }
    }
}
