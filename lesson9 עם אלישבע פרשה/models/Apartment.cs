using System;
using System.Collections.Generic;

namespace lesson9.models;

public partial class Apartment
{
    public long Id { get; set; }

    public string Adress { get; set; } = null!;

    public int Price { get; set; }

    public double Size { get; set; }

    public long Phone { get; set; }

    public virtual ICollection<InterestTable> InterestTables { get; set; } = new List<InterestTable>();
}
