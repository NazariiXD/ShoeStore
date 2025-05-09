﻿namespace ShoeStore.Domain.Entities.Users;

public partial class Address
{
    public Guid UserId { get; set; }

    public string Street { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Country { get; set; } = null!;

    public string PostalCode { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}

