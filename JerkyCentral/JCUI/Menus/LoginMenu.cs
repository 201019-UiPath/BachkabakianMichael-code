// using System;
// using JCDB;
// using JCDB.Models;
// using JCLib;
// using System.Collections.Generic;
// //using statements for menus.customer menu & menus.manager menu
// //serilog stuff



// namespace JCUI.Menus
// {
//     public class LoginMenu : IMenu
//     {
//         private string userInput;
//         private User validUser; //user after their name and pw have been confirmed
//         private JCContext context;
//         private IUserRepo userRepo;
//         private ILocationRepo locationRepo;
//         private ICartRepo cartRepo;
//         private UserServices userServices;
//         private LocationServices locationServices;
//         private CartServices cartServices;

//         public LoginMenu(JCContext context, IUserRepo userRepo, ILocationRepo locationRepo, ICartRepo cartRepo)
//         {
//             this.context = context;
//             this.userRepo = userRepo;
//             this.locationRepo = locationRepo;
//             this.cartRepo = cartRepo;
//             this.userServices = new UserServices(userRepo);
//             this.locationServices = new LocationServices(locationRepo);
//             this.cartServices = new CartServices(cartRepo);
//         }

//         public void Start() 
//         {
//             do {
//                 System.Console.WriteLine("You've arrived at JerkyCentral! Sign in or exit with the options below");

//                 System.Console.WriteLine("Press [0] to sign in to you account");
//                 System.Console.WriteLine("Press [1] to exit the application");

//                 userInput = Console.ReadLine();

//                 switch (userInput)
//                 {
//                     case "1":
//                         User user = SignIn();
//                         break;
//                     case "2":
//                         System.Console.WriteLine("Come back soon!");
//                         break;
//                     default:
//                         System.Console.WriteLine("Put on your glasses and try again");
//                         break;
//                 }

//             } while(!userInput.Equals("2"));
//         }


//         public User SignIn()
//         {
//             string name;
//             string password;
//             User user = new User();

//             Console.WriteLine("Enter your name: ");
//             name = Console.ReadLine();

//             Console.WriteLine("Enter your password: ");
//             password = Console.ReadLine();

//             try {
//                 user = userServices.GetUserByName(name);
//                 if(user.PassWord != password)
//                 {
//                     throw new System.ArgumentException();
//                 } else 
//                 {
//                     validUser = user;

//                     if(user.ManagerStatus == true)
//                     {
//                         //open manager menu
//                     } else 
//                     {
//                         //customer menu declarationa & initialization goes here
                        

//                         try{
//                             cartServices.DeleteCart(cartServices.GetCartById(validUser.UserID));
//                         } catch(InvalidOperationException) {}
//                         finally
//                         {
//                             Cart sessionCart = new Cart();
//                             sessionCart.user = validUser.UserID;
//                             cartServices.AddCart(sessionCart);

//                             //open customer menu with customermenu.start()
//                         }
//                     }


//                 }//more logging stuff and a return value around here
//             }

//         }

//     }
// }