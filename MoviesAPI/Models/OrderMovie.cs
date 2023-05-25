using System;
using System.Collections.Generic;

namespace MoviesAPI.Models;

public partial class OrderMovie
{
    public int OrderId { get; set; }

    public int MovieId { get; set; }

    public DateTime OrderDate { get; set; }

    public virtual Movie Movie { get; set; }

    public virtual Order Order { get; set; }
}
