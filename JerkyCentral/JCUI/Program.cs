using System;
using UserLib;

namespace JCUI
{
    class Program
    {
        static void Main(string[] args)
        {
            User customer = new User();
            System.Console.WriteLine($"User info is {customer.FName} {customer.LName}");
        }
    }
}
