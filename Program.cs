using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop_colab
{
    internal class Program
    {
        public static string UserName = "";

        static void Main()
        {
            Start();
        }// end of Main()
        static void Start()
        {
            Console.WriteLine("Welcome to our eShop, please enter your name");
            UserName = Console.ReadLine();
            Console.WriteLine("Welcome " + UserName + " Please select an option from the menu below");
            Console.WriteLine("{1} Check Balance \n [2] Clothing Menu \n [3] Technoloy Menu");
            MenuOne();

        }//end of Start()


        static void MenuOne()
        {
            Console.WriteLine("This is the clothing menu/n");



        }//end of MenuOne()


    }// end of internal class program


} // end of namespace
