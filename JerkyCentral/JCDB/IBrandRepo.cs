using System;
using System.Collections.Generic;

namespace JCDB
{
    public class IBrandRepo
    {
        void AddBrand(Brand brand);
        List<Brand> GetAllBrands();
    }
}