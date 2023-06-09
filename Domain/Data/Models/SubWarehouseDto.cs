﻿using Proprette.Domain.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace Proprette.Domain.Data.Models;

public class SubWarehouseDto
{
    public string ItemName { get; set; }
    public ItemType ItemType { get; set; }
    public string LocationName { get; set; }
    [DataType(DataType.Date)]
    public DateTime DateTime { get; set; }
    public int Count { get; set; }

    public SubWarehouseDto(string itemName, ItemType itemType, string locationName, DateTime dateTime, int count)
    {
        ItemName = itemName;
        ItemType = itemType;
        LocationName = locationName;
        DateTime = dateTime;
        Count = count;
    }
}
