using System;

namespace Question_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Question 04
            Write a program that prompts the user for a number (that may be a fraction)

            The program reads in the input and print the following:
            the input as a double,
            the input as an int
            and finally the input as a char.

            e.g. if the input is 65.790,
            then the output will be 65.790, 65, and A.

            input
            number (fraction)

            processing
            prompt user to enter a number
            read and store number as string
            convert string to double
            convert string to int
            convert string to char
            display 

            output
            display user input as double, int, and char

             */

            // input
            Console.WriteLine("Type any number (may be a fraction)");

            // algorithm
            string userInput = Console.ReadLine();
            double doubleNumber = Convert.ToDouble(userInput);
            int intNumber = Convert.ToInt32(doubleNumber);
            char charLetter = Convert.ToChar(intNumber);

            // display
            Console.WriteLine($"The number as a double is: {doubleNumber}");
            Console.WriteLine($"The number as an int is: {intNumber}");
            Console.WriteLine($"The number as a char is: {charLetter}");

        }
    }
}

