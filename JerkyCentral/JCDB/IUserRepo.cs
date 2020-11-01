using System;
using System.Collections.Generic;

namespace JCDB
{
    public interface IUserRepo
    {
        void AddUser(User user);
        List<User> GetAllUsers();
    }
}