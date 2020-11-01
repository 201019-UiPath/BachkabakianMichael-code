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
        void AddInventory(Inventory inventory);
        List<Inventory> GetAllInventories();
    }
}