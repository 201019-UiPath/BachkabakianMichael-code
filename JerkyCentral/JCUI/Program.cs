﻿using System;
using UserLib;
using JCUI.Menus;

namespace JCUI
{
    class Program
    {
        static void Main(string[] args)
        {   //0. Create user obj with constructor from user class 
            // User customer = new User();

            // System.Console.WriteLine("add some1");
            // string test = Console.ReadLine();
            // User.AddNames(test);

            // foreach(var names in User.GetNames()){
            //     System.Console.WriteLine(names);
            // }
            IMenu startMenu = new CustomerMenu();
            startMenu.Start();
            
            //1. Welcome message & Prompt user for login info (Email & PW)
            /*System.Console.WriteLine("Welcome to Jerky Central, please enter your email address: ");
            Console.ReadLine();

            **code that checks if input matches a existing email  in the list in db
            
            System.Console.WriteLine("Please enter your Password: ");
            Console.ReadLine();

            **code that checks if input is the correct pw for that email

            */

            //2. Opens either customer menu or manager menu based on users manager status value.


            //3. all the menu stuff next
            


            

            
           
        }
    }
}