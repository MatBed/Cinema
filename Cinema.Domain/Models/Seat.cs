using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Models
{
    public class Seat
    {
        public int Number { get; set; }
        public char Row { get; set; }
        public SeatType Type { get; set; }
    }
}
