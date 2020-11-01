using System;
using System.Collections.Generic;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for product categories
    /// </summary>
    public interface ICategoryRepo
    {
        void AddCategory(Category category);
        List<Category> GetAllCategories();
    }
}