using System;
using System.Collections.Generic;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for JerkyCentral locations
    /// </summary>
    public interface ILocationRepo
    {
        void AddLocation(Location location);
        List<Location> GetAllLocations();
    }
}