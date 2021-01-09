using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Models
{
    public class Movie : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public double Rate { get; set; }
        public MovieCategory Category { get; set; }
        public MovieType Type { get; set; }
        public int Length { get; set; }
        public string DirectorName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public bool IsActive { get; set; }

        public ISet<Ticket> Tickets { get; set; }
    }
}
