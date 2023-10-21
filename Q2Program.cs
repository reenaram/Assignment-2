using System;

namespace Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Question 02: 
            Write a program to ask the user about the validity of a simple statement.
            The program should accept the response then display the statement as well as the response.
            The response should be true or false.
            For this question, you must use a variable of type bool.
            It is useful to know that Convert.ToBoolean() can work with true, True, tRue, TRUE etc. 

            input
            user's response true (or false)

            processing
            1. prompt user if statement is true or false
            2. read user input as string
            3. convert from string to bool (and store)
            4. display statement and user response

            output
            statement and user's response
    
            */

            // declare variable
            bool statement;

            // collect inputs
            Console.Write("2 > 1. Is this statement true or false? Enter 'true' or 'false'.");

            // algorithm
            string input = Console.ReadLine();
            statement = Convert.ToBoolean(input);

            // display results

            Console.WriteLine($"The statement '2 > 1' is: {statement}");

        }
    }
}

