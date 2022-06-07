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
        public static decimal balance = 100;

        public static int shirt = 0;
        public static int shorts = 0;
        public static int hats = 0;
        public static int gloves = 0;
        //public static int Balance = 100;
        //***Array for holding options for menus***(//

        public static string[] ClothingOptions = {"\tT-Shirt\n\tDescription: Cotton t-shirt, sizes: Small, Medium, Large\n\tPrice: $10\n",
                    "\tShorts\n\tDescription: Polyester shorts, sizes: Small, Medium, Large\n\tPrice: $15\n",
                    "\tJersey\n\tDescription: Wool Jersey , sizes: Small, Medium, Large\n\tPrice: $40",
                    "\tPants\n\tDescription: Blended Wool and polyester pants , sizes: Small, Medium, Large\n\tPrice: $40",};


        public static string Confirm = "";

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

            Console.ReadLine();
            Console.WriteLine("test");
            ClothingMenu();

        }//end of Start()


        static void ClothingMenu()
        {
            Console.WriteLine("This is the clothing menu, please select items using they corresponding key.\n");
            
            for (int i = 0; i < ClothingOptions.Length; i++)
            {
                Console.WriteLine(ClothingOptions[i]);
            }
            
            
            
           
        }//end of MenuOne()


    }// end of internal class program


} // end of namespace
