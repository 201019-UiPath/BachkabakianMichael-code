using System;
using System.Collections.Generic;
using JCDB.Models;

namespace JCDB
{
    public interface IUserRepo
    {
        /// <summary>
        /// Data access interface for Users
        /// </summary>
        /// <param name="user"></param>
        void AddUser(User user);
        List<User> GetAllUsers();
    }
}