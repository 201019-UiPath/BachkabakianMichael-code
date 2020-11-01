using System;
using System.Collections.Generic;

namespace JCDB
{
    public interface IInventoryRepo
    {
        void AddInventory(Inventory inventory);
        List<Inventory> GetAllInventories();
    }
}