using System;
using System.Collections.Generic;

namespace JCDB
{
    public interface ILocationRepo
    {
        void AddLocation(Location location);
        List<Location> GetAllLocations();
    }
}