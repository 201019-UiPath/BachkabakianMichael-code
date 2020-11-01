using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Repository using files
    /// </summary>
    public class FileRepo : IBrandRepo, ICategoryRepo, IInventoryRepo, ILocationRepo, IOrderLineRepo, IOrderRepo, IProductRepo, IUserRepo
    {
        string filepath = "JerkyCentral/JCDB/Users/Users.txt";
        /// <summary>
        /// brand repo methods
        /// </summary>
        /// <param name="brand"></param>
        public async void AddBrandAsync(Brand brand)
        {
            using(FileStream fs = File.Create(filepath))
            {
                await JsonSerializer.SerializeAsync(fs, brand);
                System.Console.WriteLine("Brand is being written to file");
            }
        }
        public List<Brand> GetAllBrands()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// category repo methods
        /// </summary>
        /// <param name="category"></param>
        public void AddCategory(Category category)
        {
            throw new System.NotImplementedException();
        }
        public List<Category> GetAllCategories()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// inventory repo methods
        /// </summary>
        /// <param name="inventory"></param>
        public void AddInventory(Inventory inventory)
        {
            throw new System.NotImplementedException();
        }
        public List<Inventory> GetAllInventories()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// location repo methods
        /// </summary>
        /// <param name="location"></param>
        public void AddLocation(Location location)
        {
            throw new System.NotImplementedException();
        }
        public List<Location> GetAllLocations()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// orderline repo methods
        /// </summary>
        /// <param name="orderline"></param>
        public void AddOrderLine(OrderLine orderline)
        {
            throw new System.NotImplementedException();
        }
        public List<OrderLine> GetAllOrderLines()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// order repo methods
        /// </summary>
        /// <param name="order"></param>
        public void AddOrder(Order order)
        {
            throw new System.NotImplementedException();
        }
        public List<Order> GetAllOrders()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// product repo methods
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
        public List<Product> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// user repo methods
        /// </summary>
        /// <param name="user"></param>
        public void AddUser(User user)
        {
            throw new System.NotImplementedException();
        }
        public List<User> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }
    }
}