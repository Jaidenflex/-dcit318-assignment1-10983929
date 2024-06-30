using System;

class TicketPriceCalculator
{
    static void Main()
    {
        // Prompt the user to enter their age
        Console.Write("Enter your age: ");
        string input = Console.ReadLine();

        // Convert the input string to an integer
        if (int.TryParse(input, out int age))
        {
            // Determine the ticket price based on the age
            int ticketPrice;

            if (age <= 12 || age >= 65)
            {
                ticketPrice = 7; // Discounted price for children and senior citizens
            }
            else
            {
                ticketPrice = 10; // Regular price
            }

            // Display the ticket price
            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }
        else
        {
            // Display an error message if the input is not a valid integer
            Console.WriteLine("Error: Invalid input. Please enter a valid age.");
        }
    }
}
