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
        public static string Password = "";
        public decimal balance = 100;

        public static int shirt = "";

        //public static int Balance = 100;

        private static string Confirm = "";

        static void Main()
        {
            

            Console.WriteLine("Welcome to our eShop, please enter your name");
            UserName = Console.ReadLine();
            Console.WriteLine("Welcome " + UserName + " Please enter a password/pin you would like to use");
            Password = Console.ReadLine();
            Console.WriteLine($"Thank you, your usname is {UserName} and your password is {Password} press Y to confirm or N to reset.");
            Confirm = Console.ReadLine();
            while(Confirm != "y")
            {
                
                Console.WriteLine("\n\t*******Restarting********\n \n");
                Main();

            }
                Console.WriteLine("\n\t******Confirmed******\n \n");
                Start();
            


            Start();
        }// end of Main()
        static void Start()
        {
            Console.WriteLine("Please choose from the options below.");
            Console.WriteLine(" {1} Check Balance \n [2] Clothing Menu \n [3] Technoloy Menu");
            Console.WriteLine("test");
            MenuOne();

        }//end of Start()


        static void MenuOne()
        {
            Console.WriteLine("This is the clothing menu, please select items using they corresponding key./n");
            Console.WriteLine("[1] T-Shirt, [2] Shorts, [3] Hat, [4] Trousers, [5] Gloves.");


        }//end of MenuOne()


    }// end of internal class program


} // end of namespace
