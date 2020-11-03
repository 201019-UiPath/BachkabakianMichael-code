using JCDB;
using JCDB.Models;
using System.Collections.Generic;

namespace JCLib
{
    public class InventoryServices
    {
        private IInventoryRepo repo;

        public InventoryServices(IInventoryRepo repo)
        {
            this.repo = repo;
        }
        public void AddInventory(Inventory inventory)
        {
            repo.AddInventoryAsync(inventory);
        }
        public void UpdateInventory(Inventory inventory)
        {
            repo.UpdateInventory(inventory);
        }
        public void DeleteInventory(Inventory inventory)
        {
            repo.DeleteInventory(inventory);
        }
        public Inventory GetInventoryById(int id)
        {
            Inventory inventory = repo.GetInventoryById(id);
            return inventory;
        }
        public List<Inventory> GetAllInventories(int id)
        {
            List<Inventory> inventories = repo.GetAllInventoryById(id);
            return inventories;
        }
    }
}