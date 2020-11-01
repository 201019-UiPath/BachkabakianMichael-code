using System;
using System.Collections.Generic;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for JerkyCentral users
    /// </summary>
    public interface IUserRepo
    {
        void AddUserAsync(User user);
        List<User> GetAllUsers();
    }
}