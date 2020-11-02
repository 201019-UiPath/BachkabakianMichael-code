using System;
using System.Collections.Generic;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for JerkyCentral products
    /// </summary>
    public interface IProductRepo
    {
        void AddProductAsync(Product product);
        List<Product> GetAllProducts();
    }
}