using System;
using System.Collections.Generic;

namespace MoviesAPI.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public decimal TotalPrice { get; set; }

    public virtual ICollection<OrderMovie> OrderMovies { get; set; } = new List<OrderMovie>();
}
