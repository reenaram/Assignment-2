using System;

namespace Question05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Question 05
            Adult ticket cost $3.75 and child ticket cost $2.25.
            Write a program to prompt the user for the amount of adult and child ticket that she needs.
            The program will display a user-friendly message of the number of tickets bought
            as well as the total cost.

            (Use the "C" format-string for currency). 

            input
            number of adult ticket(s)
            number of child ticket(s)

            processing
            prompt user to enter # of adult and children ticket(s)
            read and store user input
            calculate cost of adult tickets: $3.75 multiplied by # of adult tix
            calculate cost of adult tickets: $2.25 multiplied by # of children tix
            display total # of tickets bought and total cost 

            output
            display total # of tickets bought and total cost 

            */

            // declare variables

            int adultTickets;
            int childTickets;
            int totalTickets;
            decimal totalCost;

            // input
            Console.WriteLine("Please provide the required number of tickets:");

            Console.WriteLine("How many adult tickets do you need?");
            adultTickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many children tickets do you need?");
            childTickets = Convert.ToInt32(Console.ReadLine());

            // algorithm

            totalTickets = adultTickets + childTickets;
            totalCost = (decimal)(adultTickets * 3.75 + childTickets * 2.25);
            

            // display
            Console.WriteLine($"Amount of tickets purchased: {totalTickets}");
            Console.WriteLine($"Total cost: {totalCost:C}");

        }
    }
}

