using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Domain.Models
{
    public enum SeatType
    {
        Standard = 1,
        VIP = 2
    }

    public enum HallType
    {
        Normall = 2,
        Big = 3,
        VIP = 4
    }

    public enum MovieCategory
    {
        Thriller = 1,
        Action = 2,
        Comedy = 3,
        Drama = 4,
        Biography = 5,
        Horror = 6
    }

    public enum MovieType
    {
        New=1,
        Popular=2,
        Preview = 3,
        TopRated = 4
    }
}
