using System;
using System.Collections.Generic;

namespace MoviesAPI.Models;

public partial class Movie
{
    public int MovieId { get; set; }

    public string Title { get; set; }

    public string Genre { get; set; }

    public decimal Rating { get; set; }

    public DateTime ReleaseDate { get; set; }

    public virtual ICollection<OrderMovie> OrderMovies { get; set; } = new List<OrderMovie>();
}
