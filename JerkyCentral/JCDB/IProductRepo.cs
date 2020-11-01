using System;
using System.Collections.Generic;

namespace JCDB
{
    public interface IProductRepo
    {
        void AddProduct(Product product);
        List<Product> GetAllProducts();
    }
}