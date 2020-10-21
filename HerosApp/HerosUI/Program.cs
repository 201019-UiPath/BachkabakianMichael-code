using System;
using HerosLib;

namespace HerosUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region default constructor
            /*Hero obj = new Hero();
            Console.WriteLine($"{obj.id} {obj.name}");*/
            #endregion
            #region Parameterized constructor
            Hero obj1 = new Hero(2, "Narco");
            Console.WriteLine($"{obj1.id} {obj1.name}");
            #endregion
        }
    }
}
