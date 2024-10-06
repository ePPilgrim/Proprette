﻿using Entity.BasicData;

namespace Entity.StaticData;

public class Warehouse
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public int AddressId { get; set; }
    public Address Address { get; set; } = null!;
}