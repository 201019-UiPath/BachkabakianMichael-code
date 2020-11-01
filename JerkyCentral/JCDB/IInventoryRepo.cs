using System;
using System.Collections.Generic;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for location inventories
    /// </summary>
    public interface IInventoryRepo
    {
        void AddInventoryAsync(Inventory inventory);
        List<Inventory> GetAllInventories();
    }
}