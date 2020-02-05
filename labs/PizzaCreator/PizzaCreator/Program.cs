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
                    case Command.Edit: EditOrder(); break;
                    case Command.Quit: done = ReadBoolean("Are you sure that you want to exit the program?"); break;
                };
            } while (!done);

        }

        private static void EditOrder ()
        {
            if (String.IsNullOrEmpty(sizes))
            {
                Console.WriteLine("No food in current order, please add food to your order to edit.");
                return;
            }

            {
                if (String.Compare(sizes, "1", true) == 0)
                    Console.Write("Current size: Small $5.00\n");
                else if (String.Compare(sizes, "2", true) == 0)
                    Console.Write("Current size: Medium $6.25\n");
                else if (String.Compare(sizes, "3", true) == 0)
                    Console.Write("Current size: Large $8.75\n");
            }
            //Size Selection
            size = ReadInt32("Enter Size\n1 for small($5)\n2 for medium($6.25)\n3 for large($8.75)\n", 1, 3);
            sizes = size.ToString();
            if (String.Compare(sizes, "1", true) == 0)
                sprice = 5;
            else if (String.Compare(sizes, "2", true) == 0)
                sprice = 6.25;
            else if (String.Compare(sizes, "3", true) == 0)
                sprice = 8.75;

            //Meat Selection 
            bool mdone = false;

            do
            {
                Console.WriteLine("Current Meat Selections: Bacon: " + bacon + " Ham: " + ham + " Pepperoni: " + pepperoni +" Sausage: " + sausage);
                meats = ReadInt32("Enter Meats ($0.75 per meat)\n1 for Bacon\n2 for Ham\n3 for Pepperoni\n4 for Sausage\n5 to finish selecting meats\n", 1, 5);
                 
                double baconprice;
                double hamprice;
                double pepprice;
                double sausageprice;


                string meatstring = meats.ToString();
                baconprice =bacon == true ? 0.75 : 0;
                hamprice =ham == true ? 0.75 : 0;
                pepprice =pepperoni == true ? 0.75 : 0;
                sausageprice =sausage == true ? 0.75 : 0;
                mprice = baconprice + hamprice + pepprice + sausageprice;

                if (String.Compare(meatstring, "1", true) == 0)

                    bacon = !bacon;
                else

                    if (String.Compare(meatstring, "2", true) == 0)
                    ham = !ham;
                else if (String.Compare(meatstring, "3", true) == 0)
                    pepperoni = !pepperoni;
                else if (String.Compare(meatstring, "4", true) == 0)
                    sausage = !sausage;
                else if (String.Compare(meatstring, "5", true) == 0)
                    mdone = true;

            } while (mdone == false);

            //Vegetable Selection    
            bool vdone = false;
            do
            {
                Console.WriteLine("Current Vegetable Selections: Black Olives " + bolive + " Mushrooms: " + mushroom + " Olives: " + olive +" Peppers: " + peppers);
                vegetables = ReadInt32("Enter Vegetables ($0.50 per veggie)\n1 for Black Olives\n2 for Mushrooms\n3 for Olives\n4 for Peppers\n5 to finish selecting vegetables\n", 1, 5);
                
                double boliveprice;
                double peppersprice;
                double oliveprice;
                double mushroomprice;


                string vegestring = vegetables.ToString();
                boliveprice =bolive == true ? 0.5 : 0;
                mushroomprice =mushroom == true ? 0.5 : 0;
                peppersprice =peppers == true ? 0.5 : 0;
                oliveprice =olive == true ? 0.5 : 0;
                vprice = boliveprice + oliveprice + peppersprice + mushroomprice;

                if (String.Compare(vegestring, "1", true) == 0)
                    bolive = !bolive;
                else if (String.Compare(vegestring, "2", true) == 0)
                    mushroom = !mushroom;
                else if (String.Compare(vegestring, "3", true) == 0)
                    olive = !olive;
                else if (String.Compare(vegestring, "4", true) == 0)
                    peppers = !peppers;
                else if (String.Compare(vegestring, "5", true) == 0)
                    vdone = true;

            } while (vdone == false);

            string editsauces = sauce.ToString();
            if (String.Compare(editsauces, "1", true) == 0)
                Console.WriteLine("Current Sauce: Traditional $0.00\n");
            else if (String.Compare(editsauces, "2", true) == 0)
                Console.WriteLine("Current Sauce: Garlic $1.00\n");
            else if (String.Compare(editsauces, "3", true) == 0)
                Console.WriteLine("Current Sauce: Oregano $1.00\n");

            //Sauce Selection
            sauce = ReadInt32("Enter Sauce\n1 for Traditional ($0)\n2 for Garlic($1)\n3 for Oregano ($1)\n", 1, 3);
            string sauces = sauce.ToString();
            if (String.Compare(sauces, "1", true) == 0)
                saprice = 0;
            else if (String.Compare(sauces, "2", true) == 0)
                saprice = 1;
            else if (String.Compare(sauces, "3", true) == 0)
                saprice = 1;

            string editcheeses = cheese.ToString();
            if (String.Compare(editcheeses, "1", true) == 0)
                Console.WriteLine("Cheese: Regular ($0.00\n");
            else if (String.Compare(editcheeses, "2", true) == 0)
                Console.WriteLine("Cheese: Extra $1.25\n");

            //Cheese Selection
            cheese = ReadInt32("Enter Cheese\n 1 for Regular($0)\n2 for Extra($1.25)\n", 1, 2);
            string cheeses = cheese.ToString();
            if (String.Compare(cheeses, "1", true) == 0)
                cprice = 0;
            else if (String.Compare(cheeses, "2", true) == 0)
                cprice = 1.25;
            
            
            
            //Delivery Selection    
            delivery = ReadBoolean("Would you like delivery? ($2.50)\n");

            if (delivery == true)
                dprice = 2.5;
            else
                dprice = 0;

            total = sprice + mprice + vprice + saprice +cprice + dprice;
            DisplayOrder();
        }

            static int size;
            static string sizes;

            static int meats;
            static int vegetables;
            static int sauce;
            static int cheese;
            static bool delivery;
            static bool bacon = false;
            static bool ham = false;
            static bool pepperoni = false;
            static bool sausage = false;
            static bool mushroom = false;
            static bool bolive = false;
            static bool peppers = false;
            static bool olive = false;
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
            if (String.IsNullOrEmpty(sizes))
            {
                Console.WriteLine("No food in current order, please add food to your order to display.");
                return;
            }


            Console.WriteLine("Current Order:\n");
            if (String.Compare(sizes, "1", true) == 0)
                Console.WriteLine("Size: Small $5.00\n");
            else if (String.Compare(sizes, "2", true) == 0)
                Console.WriteLine("Size: Medium $6.25\n");
            else if (String.Compare(sizes, "3", true) == 0)
                Console.WriteLine("Size: Large $8.75\n");

            Console.WriteLine("Meats ($0.75 per):\nBacon: " + bacon + "\nHam: " + ham + "\nPepperoni: " + pepperoni +"\nSausage: " + sausage);
            Console.WriteLine("");

            Console.WriteLine("Vegetables ($0.50 per):\nBlack Olives " + bolive + "\nMushrooms: " + mushroom + "\nOlives: " + olive +"\nPeppers: " + peppers);
            Console.WriteLine("");

            string sauces = sauce.ToString();
            if (String.Compare(sauces, "1", true) == 0)
                Console.WriteLine("Sauce: Traditional $0.00\n");
            else if (String.Compare(sauces, "2", true) == 0)
                Console.WriteLine("Sauce: Garlic $1.00\n");
            else if (String.Compare(sauces, "3", true) == 0)
                Console.WriteLine("Sauce: Oregano $1.00\n");

            string cheeses = cheese.ToString();
            if (String.Compare(cheeses, "1", true) == 0)
                Console.WriteLine("Cheese: Regular ($0.00\n");
            else if (String.Compare(cheeses, "2", true) == 0)
                Console.WriteLine("Cheese: Extra $1.25\n");

            Console.WriteLine("Delivery ($2.50): " + delivery);
            Console.WriteLine("");

            Console.WriteLine("Total: $" + total);

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

            //Size Selection
            size = ReadInt32("Enter Size\n1 for small($5)\n2 for medium($6.25)\n3 for large($8.75)\n", 1, 3);
            sizes = size.ToString();
            if (String.Compare(sizes, "1", true) == 0)
                sprice = 5;
            else if (String.Compare(sizes, "2", true) == 0)
                sprice = 6.25;
            else if (String.Compare(sizes, "3", true) == 0)
                sprice = 8.75;
           
           //Meat Selection 
           bool mdone = false;
           do
            {
                Console.WriteLine("Current Selections: Bacon: " + bacon + " Ham: " + ham + " Pepperoni: " + pepperoni +" Sausage: " + sausage);
                meats = ReadInt32("Enter Meats ($0.75 per meat)\n1 for Bacon\n2 for Ham\n3 for Pepperoni\n4 for Sausage\n5 to finish selecting meats\n", 1, 5);
                
                double baconprice;
                double hamprice;
                double pepprice;
                double sausageprice;


                string meatstring = meats.ToString();
                baconprice =bacon == true ? 0.75 : 0;
                hamprice =ham == true ? 0.75 : 0;
                pepprice =pepperoni == true ? 0.75 : 0;
                sausageprice =sausage == true ? 0.75 : 0;
                mprice = baconprice + hamprice + pepprice + sausageprice;

                if (String.Compare(meatstring, "1", true) == 0)
                
                    bacon = !bacon;
                 else
                
                    if (String.Compare(meatstring, "2", true) == 0)
                        ham = !ham;
                    else if (String.Compare(meatstring, "3", true) == 0)
                        pepperoni = !pepperoni;
                    else if (String.Compare(meatstring, "4", true) == 0)
                        sausage = !sausage;
                    else if (String.Compare(meatstring, "5", true) == 0)
                        mdone = true;

                } while (mdone == false) ;

            //Vegetable Selection    
            bool vdone = false;
            do
            {
                Console.WriteLine("Current Selections: Black Olives " + bolive + " Mushrooms: " + mushroom + " Olives: " + olive +" Peppers: " + peppers);
                vegetables = ReadInt32("Enter Vegetables ($0.50 per veggie)\n1 for Black Olives\n2 for Mushrooms\n3 for Olives\n4 for Peppers\n5 to finish selecting vegetables\n", 1, 5);
                
                double boliveprice;
                double peppersprice;
                double oliveprice;
                double mushroomprice;


                string vegestring = vegetables.ToString();
                boliveprice =bolive == true ? 0.5 : 0;
                mushroomprice =mushroom == true ? 0.5 : 0;
                peppersprice =peppers == true ? 0.5 : 0;
                oliveprice =olive == true ? 0.5 : 0;
                vprice = boliveprice + oliveprice + peppersprice + mushroomprice;

                if (String.Compare(vegestring, "1", true) == 0)
                    bolive = !bolive;
                else if (String.Compare(vegestring, "2", true) == 0)
                    mushroom = !mushroom;
                else if (String.Compare(vegestring, "3", true) == 0)
                    olive = !olive;
                else if (String.Compare(vegestring, "4", true) == 0)
                    peppers = !peppers;
                else if (String.Compare(vegestring, "5", true) == 0)
                    vdone = true;

            } while (vdone == false);


            //Sauce Selection
            sauce = ReadInt32("Enter Sauce\n1 for Traditional ($0)\n2 for Garlic($1)\n3 for Oregano ($1)\n", 1, 3);
                string sauces = sauce.ToString();
                if (String.Compare(sauces, "1", true) == 0)
                    saprice = 0;
                else if (String.Compare(sauces, "2", true) == 0)
                    saprice = 1;
                else if (String.Compare(sauces, "3", true) == 0)
                    saprice = 1;
                
            //Cheese Selection
            cheese = ReadInt32("Enter Cheese\n 1 for Regular($0)\n2 for Extra($1.25)\n", 1, 2);
                string cheeses = cheese.ToString();
                if (String.Compare(cheeses, "1", true) == 0)
                    cprice = 0;
                else if (String.Compare(cheeses, "2", true) == 0)
                    cprice = 1.25;
           
            //Delivery Selection    
            delivery = ReadBoolean("Would you like delivery? ($2.50)\n");
            
                if (delivery == true)
                    dprice = 2.5;
                else
                    dprice = 0;
            
            total = sprice + mprice + vprice + saprice +cprice + dprice;
            DisplayOrder();
        }

        

        enum Command
        {
            Quit = 0,
            Add = 1,
            Display = 2,
            Edit = 3,
        }
        private static Command DisplayMenu ()
        {
            //Writes Menu in the console
            do
            {
                Console.WriteLine("Total: $" + total);
                Console.WriteLine("A)dd Food to order");
                Console.WriteLine("E)dit Order");
                Console.WriteLine("D)isplay Order");
                Console.WriteLine("Q)uit");

                var input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "a": return Command.Add;
                    case "d": return Command.Display;
                    case "e": return Command.Edit;
                    case "q": return Command.Quit;

                    default: Console.WriteLine("Invalid option"); break;
                };
            } while (true);
        }
    }
}
