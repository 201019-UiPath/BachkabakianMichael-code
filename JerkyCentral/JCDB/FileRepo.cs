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
        string brandfilepath = "JerkyCentral/JCDB/Brands/Brands.txt";
        string categoryfilepath = "JerkyCentral/JCDB/Categories/Categories.txt";
        string inventoryfilepath = "JerkyCentral/JCDB/Inventories/Inventories.txt";
        string locationfilepath = "JerkyCentral/JCDB/Locations/Locations.txt";
        string orderlinefilepath = "JerkyCentral/JCDB/OrderLines/OrderLines.txt";
        string orderfilepath = "JerkyCentral/JCDB/Orders/Orders.txt";
        string productfilepath = "JerkyCentral/JCDB/Products/Products.txt";
        string userfilepath = "JerkyCentral/JCDB/Users/Users.txt";
        
        /// <summary>
        /// brand repo methods
        /// </summary>
        /// <param name="brand"></param>
        public async void AddBrandAsync(Brand brand)
        {
            using(FileStream fs = File.Create(brandfilepath))
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
        public async void AddCategoryAsync(Category category)
        {
            using(FileStream fs = File.Create(categoryfilepath))
            {
                await JsonSerializer.SerializeAsync(fs, category);
                System.Console.WriteLine("Category is being written to file");
            }
        }
        public List<Category> GetAllCategories()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// inventory repo methods
        /// </summary>
        /// <param name="inventory"></param>
        public async void AddInventoryAsync(Inventory inventory)
        {
            using(FileStream fs = File.Create(inventoryfilepath))
            {
                await JsonSerializer.SerializeAsync(fs, inventory);
                System.Console.WriteLine("Inventory is being written to file");
            }
        }
        public List<Inventory> GetAllInventories()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// location repo methods
        /// </summary>
        /// <param name="location"></param>
        public async void AddLocationAsync(Location location)
        {
            using(FileStream fs = File.Create(locationfilepath))
            {
                await JsonSerializer.SerializeAsync(fs, location);
                System.Console.WriteLine("Location is being written to file");
            }
        }
        public List<Location> GetAllLocations()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// orderline repo methods
        /// </summary>
        /// <param name="orderline"></param>
        public async void AddOrderLineAsync(OrderLine orderline)
        {
            using(FileStream fs = File.Create(orderlinefilepath))
            {
                await JsonSerializer.SerializeAsync(fs, orderline);
                System.Console.WriteLine("OrderLine is being written to file");
            }
        }
        public List<OrderLine> GetAllOrderLines()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// order repo methods
        /// </summary>
        /// <param name="order"></param>
        public async void AddOrderAsync(Order order)
        {
            using(FileStream fs = File.Create(orderfilepath))
            {
                await JsonSerializer.SerializeAsync(fs, order);
                System.Console.WriteLine("Order is being written to file");
            }
        }
        public List<Order> GetAllOrders()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// product repo methods
        /// </summary>
        /// <param name="product"></param>
        public async void AddProductAsync(Product product)
        {
            using(FileStream fs = File.Create(productfilepath))
            {
                await JsonSerializer.SerializeAsync(fs, product);
                System.Console.WriteLine("Product is being written to file");
            }
        }
        public List<Product> GetAllProducts()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// user repo methods
        /// </summary>
        /// <param name="user"></param>
        public async void AddUserAsync(User user)
        {
            using(FileStream fs = File.Create(userfilepath))
            {
                await JsonSerializer.SerializeAsync(fs, user);
                System.Console.WriteLine("User is being written to file");
            }
        }
        public List<User> GetAllUsers()
        {
            throw new System.NotImplementedException();
        }
    }
}