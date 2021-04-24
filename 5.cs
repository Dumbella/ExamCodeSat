using System;

namespace Exam5
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int time = int.Parse(Console.ReadLine());
            string set = Console.ReadLine();

            int BreakfastSet = 5;
            int WeekendSet = 2;
            int coffee = 3;


            while (BreakfastSet > 0 || WeekendSet > 0 || coffee > 0)
            {

                if (set == "Breakfast Set")
                {
                    BreakfastSet = BreakfastSet - 1;
                    Console.WriteLine("Breakfast Set เหลือ : {0} ", BreakfastSet);
                    if (BreakfastSet == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                        set = Console.ReadLine();
                    }


                }
                else if (set == "Weekend Set")
                {
                    WeekendSet = WeekendSet - 1;
                    Console.WriteLine("Weekend Set เหลือ : {0} ", WeekendSet);
                    if (WeekendSet == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                        set = Console.ReadLine();
                    }

                }
                else if (set == "coffee")
                {
                    coffee = coffee - 1;
                    Console.WriteLine("coffee เหลือ : {0} ", coffee);
                    if (coffee == 0)
                    {
                        Console.WriteLine("Sorry your order is out of stock");
                        set = Console.ReadLine();
                    }

                }
                
                else if (set != "Breakfast Set" || set != "Weekend Set" || set != "coffee")
                {
                    Console.WriteLine("Please enter a valid menu");
                    set = Console.ReadLine();
                }
                else if(set == "End")
                {
                    Console.ReadLine();
                }
                else if (time > 11 && set == "Breakfast Set")
                {
                    Console.WriteLine("Sorry your order is not available");
                    set = Console.ReadLine();
                }
                else if (day != 6|| day != 7 && set == "Weekend Set")
                {
                    Console.WriteLine("Sorry your order is not available");
                    set = Console.ReadLine();
                }
            }
        }
    }
}
