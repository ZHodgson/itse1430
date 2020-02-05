//Zachary Hodgson
//Intro to C# programming
//1/31/2020
using System;

namespace PizzaCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pizza Creator\nThis program was written by Zachary Hodgson\nClass: Into to C# Programming\nSemester: Fall 2020");
            var done = false;
            //Menu
            do
            {
                switch (DisplayMenu())
                {
                    case Command.Add: AddFood(); break;
                    case Command.Display: DisplayOrder(); break;
                    case Command.Quit: done = ReadBoolean("Are you sure that you want to exit the program?"); break;
                };
            } while (!done);

        }
        
            static int size;
            static string sizes;
            static int meats;
            static int vegetables;
            static int sauce;
            static int cheese;
            static bool delivery;
            static double sprice;
            static double mprice;
            static double vprice;
            static double saprice;
            static double cprice;
            static double dprice;
            static double total; // = sprice + mprice + vprice + saprice +cprice + dprice;


        private static bool ReadBoolean ( string message )
        {
            //Function verifys user's Y/N response
            Console.WriteLine(message + "(Y/N)");
            do
            {
                string value = Console.ReadLine();

               if (!String.IsNullOrEmpty(value))
                {

                    if (String.Compare(value, "Y", true) == 0)
                        return true;
                    else if (String.Compare(value, "N", true) == 0)
                        return false;

                    char firstChar = value[0];

                };

                Console.WriteLine("Enter Y/N");
            } while (true);
        }

        private static void DisplayOrder ()
        {
         

            Console.WriteLine(size);

            Console.WriteLine(meats);
            
            Console.WriteLine(vegetables);

            Console.WriteLine(sauce);

            Console.WriteLine(cheese);

            Console.WriteLine(delivery);

        }
        private static string ReadString ( string message, bool required )
        {
            Console.Write(message);

            do
            {
                //var x = 10;
                string value = Console.ReadLine();

                //If required and string is empty then error
                if (!String.IsNullOrEmpty(value) || !required)
                    return value;

                if (required)
                    Console.WriteLine("Value is required");
            } while (true);
        }

        private static int ReadInt32 ( string message, int minValue, int maxValue )
        {
            Console.Write(message);

            do
            {
                //string temp = Console.ReadLine();
                var temp = Console.ReadLine();
                //int value = Int32.Parse(temp);

                //TODO: Clean this up
                //int value;
                if (Int32.TryParse(temp, out var value))
                {
                    if (value >= minValue && value <= maxValue)
                        return value;
                };

                Console.WriteLine("Value must be between minValue and maxValue");
            } while (true);
        }

        private static void AddFood ()
        {
            bool overwrite = false;
            do
            {
                
                if (!String.IsNullOrEmpty(sizes) )
                {
                    overwrite = ReadBoolean("Would you like to overwrite your existing order?");
                    if (overwrite == false)
                    { 
                        return; 
                    }
                } else
                {
                    overwrite = true;
                }
            } while (overwrite == false);

            size = ReadInt32("Enter Size\n1 for small($5)\n2 for medium($6.25)\n3 for large($8.75)\n", 1, 3);
            sizes = size.ToString();
            if (String.Compare(sizes, "1", true) == 0)
                sprice = 5;
            else if (String.Compare(sizes, "2", true) == 0)
                sprice = 6.25;
            else if (String.Compare(sizes, "3", true) == 0)
                sprice = 8.75;
            meats = ReadInt32("Enter Meats ($0.75 per meat)\n1 for Bacon\n2 for Ham\n3 for Pepperoni\n4 for Sausage\n", 1, 4);

            vegetables = ReadInt32("Enter Vegetables ($0.50 per veggie)\n1 for Black Olives\n2 for Mushrooms\n3 for Olives\n4 for Peppers\n", 1, 4);


            sauce = ReadInt32("Enter Sauce\n1 for Traditional ($0)\n2 for Garlic($1)\n3 for Oregano ($1)\n", 1, 3);
            string sauces = sauce.ToString();
            if (String.Compare(sauces, "1", true) == 0)
                saprice = 0;
            else if (String.Compare(sauces, "2", true) == 0)
                saprice = 1;
            else if (String.Compare(sauces, "3", true) == 0)
                saprice = 1;
            cheese = ReadInt32("Enter Cheese\n 1 for Regular($0)\n2 for Extra($1.25)\n", 1, 2);
            string cheeses = cheese.ToString();
            if (String.Compare(cheeses, "1", true) == 0)
                cprice = 0;
            else if (String.Compare(cheeses, "2", true) == 0)
                cprice = 1.25;
            delivery = ReadBoolean("Would you like delivery? ($2.50)\n");
            total = sprice + mprice + vprice + saprice +cprice + dprice;

        }

        enum Command
        {
            Quit = 0,
            Add = 1,
            Display = 2,
        }
        private static Command DisplayMenu ()
        {
            //Writes Menu in the console
            do
            {
                Console.WriteLine("Total: $" + total);
                Console.WriteLine("A)dd Food to order");
                Console.WriteLine("D)isplay Order");
                Console.WriteLine("Q)uit");

                var input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "a": return Command.Add;
                    case "d": return Command.Display;
                    case "q": return Command.Quit;

                    default: Console.WriteLine("Invalid option"); break;
                };
            } while (true);
        }
    }
}
