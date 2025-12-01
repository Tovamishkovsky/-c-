using System;
using System.Collections.Generic;

namespace lesson9.models;

public partial class InterestTable
{
    public int Id { get; set; }

    public long IdCustomer { get; set; }

    public long IdApartment { get; set; }

    public DateOnly Date { get; set; }

    public virtual Apartment IdApartmentNavigation { get; set; } = null!;

    public virtual Customer IdCustomerNavigation { get; set; } = null!;
}
