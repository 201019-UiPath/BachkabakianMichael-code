using System;

namespace JCUI
{
    /// <summary>
    /// Menu that is displayed to customers
    /// </summary>
    public class CustomerMenu:IMenu
    {
        public void Start()
        {
            System.Console.WriteLine("Welcome back to JerkyCentral! What would you like to do?");
            //options
            System.Console.WriteLine("[1] Place An Order");
            System.Console.WriteLine("[2] View Order History");
            System.Console.WriteLine("[3] View Location Inventory");
            //take input
            string choice = System.Console.ReadLine();

            switch (choice)
            {
                case "1":
                    System.Console.WriteLine("choice 1 has been chosen");
                        break;
                case "2":
                    System.Console.WriteLine("choice 2 has been chosen");
                        break;
                case "3":
                    System.Console.WriteLine("choice 3 has been chosen");
                        break;
                default:
                    System.Console.WriteLine("your an idiot");
                    break;
            }
        }
    }
}