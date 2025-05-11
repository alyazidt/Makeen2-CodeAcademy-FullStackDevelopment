using System;
using System.Diagnostics;
using System.Drawing;
class Program
{
    static void Main()
    {


        Console.WriteLine("Welcome to the Coffee Shop!");

        bool Order = true;
        while (Order)
        {


            CoffeShop c = new CoffeShop();
            c.display_menu();
            c.place_order();
            c.calculate_cost();
            c.display_order_summary();


            Console.Write("Do you want to take another order ? (yes / no) : ");
            string anotherOrder = Console.ReadLine().ToLower();
            if (anotherOrder != "yes")
            {
                Order = false;
                Console.WriteLine("Goodbye!");
            }

        }
            




    }




    public class CoffeShop {


        int Coffee, sizeChoice;
        string sugar, milk;
        string CoffeeName = "", size;
        double Price = 0.0;



        public void display_menu()
        {


            Console.WriteLine("Menu:");
            Console.WriteLine("1. Americano - $2.50");
            Console.WriteLine("2. Latte - $3.00");
            Console.WriteLine("3. Cappuccino - $3.50");
            Console.Write("Select a coffee (1-3): ");

        }

        
        public void place_order()
        {

                Coffee = Convert.ToInt32(Console.ReadLine());
                



                Console.WriteLine("Customizations:");
                Console.WriteLine("1. Small");
                Console.WriteLine("2. Medium");
                Console.WriteLine("3. Large");
                Console.Write("Select a size (1-3): ");


                sizeChoice = Convert.ToInt32(Console.ReadLine());


                


                Console.Write("Do you want sugar? (yes/no): ");
                sugar = Console.ReadLine().ToLower();
                Console.Write("Do you want milk? (yes/no): ");
                milk = Console.ReadLine().ToLower();
               


        }



        public void calculate_cost()
        {


            switch (Coffee)
            {
                case 1:
                    CoffeeName = "Americano";
                    Price = 2.50;
                    break;
                case 2:
                    CoffeeName = "Latte";
                    Price = 3.00;
                    break;
                case 3:
                    CoffeeName = "Cappuccino";
                    Price = 3.50;
                    break;
                default:
                    Console.WriteLine("Invalid Try again.");
                    return;
            }


            size = sizeChoice switch
            {
                1 => "Small",
                2 => "Medium",
                3 => "Large",
                _ => "Null"
            };

            if (sizeChoice == 3) Price += 0.50;
            else if (sizeChoice == 2) Price -= 0.35;
            else if (sizeChoice == 1) Price -= 0.25;



        }


        public void display_order_summary()
        {

            Console.WriteLine("\nYour Order Summary:");
            Console.Write($"{CoffeeName} ({size})");


            if (sugar == "yes")
            {
                Console.Write(" with sugar");
            }
            if (milk == "yes")
            {
                Console.Write(" and milk");
            }


            Console.WriteLine($"\nTotal Cost: ${Price:F2}");
            Console.WriteLine("Thank you for ordering!\n");

        }




    }


}
