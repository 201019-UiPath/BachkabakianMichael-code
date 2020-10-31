using System;
using System.Collections.Generic;

namespace UserLib
{
    public class User{

        public static List<string> names = new List<string>();

        public static List<string> emails = new List<string>();

        public static List<string> passwords = new List<string>();

        public static List<bool> managerstatus = new List<bool>();

        public User()
        {
            names.Add("joe");
            names.Add("bill");
            names.Add("rob");
            names.Add("sam");

            emails.Add("joe@yahoo.com");
            emails.Add("bill@gmail.com");
            emails.Add("rob@hotmail.com");
            emails.Add("sam@revature.net");

            passwords.Add("mypassword123");
            passwords.Add("dontforget1");
            passwords.Add("qazwsx999");
            passwords.Add("bingbangboom11");

            managerstatus.Add(false);
            managerstatus.Add(true);
            managerstatus.Add(true);
            managerstatus.Add(true); 

        }
        public static List<string> GetNames()
        {
            return names;
        }

        public static List<string> GetEmails()
        {
            return emails;
        }

        public static List<string> GetPasswords()
        {
            return passwords;
        }

        public static List<bool> GetManagerStatus()
        {
            return managerstatus;
        }

        public static void AddNames(string name)
        {
            if(names.Contains(name))
            {
                System.Console.WriteLine("That Person is already in the Database");
            } else
            {
                names.Add(name);
            }
        }
        public static void RemoveNames(string name)
        {
            if(names.Contains(name))
            {
                names.Remove(name);
            } 

        }

        public static void AddEmails(string email)
        {
            if(emails.Contains(email))
            {
                System.Console.WriteLine("That Email Address is already in the Database");
            } else
            {
                emails.Add(email);
            }
        }
        public static void RemoveEmails(string email)
        {
            if(emails.Contains(email))
            {
                emails.Remove(email);
            } 

        }

        public static void AddPasswords(string password)
        {
            if(passwords.Contains(password))
            {
                System.Console.WriteLine("That Password is already in the Database");
            } else
            {
                passwords.Add(password);
            }
        }
        public static void RemovePasswords(string password)
        {
            if(passwords.Contains(password))
            {
                passwords.Remove(password);
            } 

        }

        //get customers entire customer record 
        public static void GetUserRecord(int listindex)
        {

            System.Console.WriteLine($"{names[listindex]} {emails[listindex]} {passwords[listindex]} {managerstatus[listindex]}");

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
