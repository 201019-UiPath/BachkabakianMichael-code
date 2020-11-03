using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for location inventories
    /// </summary>
    public interface IInventoryRepo
    {
        void AddInventoryAsync(Inventory inventory);
        void UpdateInventory(Inventory inventory);
        void DeleteInventory(Inventory inventory);
        Inventory GetInventoryById(int id);
        List<Inventory> GetAllInventoryById(int id);
    }
}