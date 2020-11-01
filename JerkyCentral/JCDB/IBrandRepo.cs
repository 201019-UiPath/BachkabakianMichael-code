using System;
using System.Collections.Generic;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for product brands
    /// </summary>
    public interface IBrandRepo
    {
        void AddBrandAsync(Brand brand);
        List<Brand> GetAllBrands();
    }
}