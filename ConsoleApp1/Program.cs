using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            string location;
            Console.Write("Please enter your location: ");
            location = Console.ReadLine();

            var today = DateTime.Now.ToString("M-d-yyyy");

            DateTime christmas = new DateTime(2021, 12, 25);
            var currentDate = DateTime.Now;

            var num_days_to_christmas = (christmas.Date - currentDate.Date).Days;

            Console.WriteLine($"My name is {name}. I am from {location}.");
            Console.WriteLine($"The current date is: {today}");
            Console.WriteLine($"There are {num_days_to_christmas} days until Christmas.");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("Please enter the width of the wood: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("Please enter the height of the wood: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");

            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");

        }
    }
}
