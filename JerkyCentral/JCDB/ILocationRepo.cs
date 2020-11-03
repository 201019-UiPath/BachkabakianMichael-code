using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for JerkyCentral locations
    /// </summary>
    public interface ILocationRepo
    {
        void AddLocationAsync(Location location);
        void UpdateLocation(Location location);
        void DeleteLocation(Location location);
        Location GetLocationById(int id);
        Location GetLocationByName(string name);
        Task<List<Location>> GetAllLocationsAsync();
    }
}