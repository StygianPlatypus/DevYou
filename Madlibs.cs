using System;

namespace Madlibs
{
    class Program
    {
        static void Main(string[] args)
        {
            // A game of mad libs
            // The console will prompt the user to enter in a series of different words
            // User inputs are declared and initialized after each entry
            // After the last word is entered, the whole mad lib is printed out using string interpolation to put in the user's words
            Console.WriteLine("Let's play Mad Libs! First, give me an adjective.");
            string adj1 = Console.ReadLine();
            Console.WriteLine("Now give me a noun.");
            string noun1 = Console.ReadLine();
            Console.WriteLine("Okay, now how about a past tense verb.");
            string verb1 = Console.ReadLine();
            Console.WriteLine("Interesting! Let's try an adverb.");
            string adv1 = Console.ReadLine();
            Console.WriteLine("Now another adjective.");
            string adj2 = Console.ReadLine();
            Console.WriteLine("And a noun to go with it!");
            string noun2 = Console.ReadLine();
            Console.WriteLine("Another noun!");
            string noun3 = Console.ReadLine();
            Console.WriteLine("Let's try an adjective this time.");
            string adj3 = Console.ReadLine();
            Console.WriteLine("Almost there! Give me a verb.");
            string verb2 = Console.ReadLine();
            Console.WriteLine("Now an adverb.");
            string adv2 = Console.ReadLine();
            Console.WriteLine("How about a verb ending in -ed?");
            string verb3 = Console.ReadLine();
            Console.WriteLine("One more adjective. Last one so make it count!");
            string adj4 = Console.ReadLine();
            Console.WriteLine($"Today I went to the zoo. I saw a {adj1} {noun1} jumping up and down in its tree. He {verb1} {adv1} through the large tunnel that led to its {adj2} {noun2}. " +
                $"I got some peanuts and passed them through the cage to a gigantic gray {noun3} towering above my head. Feeding that animal made me hungry. I went to get a {adj3} scoop of ice cream. " +
                $"It filled my stomach. Afterwards I had to {verb2} {adv2} to catch our bus. When I got home I {verb3} my mom for a {adj4} day at the zoo.)");
            Console.ReadLine();

        }
    }
}
