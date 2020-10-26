using System;
using System.Collections.Generic;

namespace UserLib
{
    public class User{

        public static List<string> names = new List<string>();


        public User()
        {
            names.Add("joe");
            names.Add("bill");
            names.Add("rob");
            names.Add("sam");
        }
        public static List<string> GetNames()
        {
            return names;
        }

        public static void RemoveNames(string name)
        {
            if(names.Contains(name))
            {
                names.Remove(name);
            } 

        }
        #region code to prompt user for a name to remove, and to remove it from the names list (goes in the main method)
        /*System.Console.WriteLine("Please enter a name to remove: ");
            string nm = Console.ReadLine();
            User.RemoveNames(nm);

            System.Console.WriteLine();

            foreach(var name in User.names)
            {
                System.Console.WriteLine(name);

            }
            */
        #endregion
    }
    
}
