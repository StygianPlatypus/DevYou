using System;

namespace VacationBudgetPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            string mex = "Mexico";
            string jam = "Jamaica";
            Console.WriteLine("Welcome to the Vacation Budget Planner XL!\r\nWhat is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Would you like to travel to {mex} or {jam}?");
           
            Console.ReadLine();
        }
    }
}
