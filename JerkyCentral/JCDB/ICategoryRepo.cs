using System;
using System.Collections.Generic;

namespace JCDB
{
    public interface ICategoryRepo
    {
        void AddCategory(Category category);
        List<Category> GetAllCategories();
    }
}