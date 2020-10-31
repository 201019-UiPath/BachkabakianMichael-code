using System;

namespace JCUI
{
    /// <summary>
    /// Menu that is displayed to managers
    /// </summary>
    public class ManagerMenu:IMenu
    {
        public void Start()
        {
            System.Console.WriteLine("Entered Manager Console. What would you like to do?");
            //options
            System.Console.WriteLine("[1] Replenish Inventory");
            System.Console.WriteLine("[2] View Location Inventory");
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
                default:
                    System.Console.WriteLine("your an idiot");
                    break;
            }
        }
    }
}