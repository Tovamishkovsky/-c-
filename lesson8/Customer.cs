using System;
using System.Collections.Generic;

namespace Apartment;

public partial class Customer
{
    public long Id { get; set; }

    public string FullName { get; set; } = null!;

    public long Phone { get; set; }

    public virtual ICollection<InterestTable> InterestTables { get; set; } = new List<InterestTable>();
}
