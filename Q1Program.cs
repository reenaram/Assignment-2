using System;

namespace Question01
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             
            Question 01: 
            Write a program to prompt the user to enter a single character.
            The program should display a message like “Your response was y”.
            For this question, you must use a variable of type char.

            input
            singleCharacter

            processing
            1. collect value for singleCharacter
            2. store input for singleCharacter
            3. print input with message including singleCharacter

            output
            message 
    
             
            */

            //step 1: declare variable
            char singleCharacter;

            //step 2: prompt user to collect input
            Console.Write("Please enter a single character: ");

            //step 3: read user input and store
            singleCharacter = Convert.ToChar(Console.ReadKey().KeyChar);

            //step 4: display
            Console.WriteLine("\nYour response was: ");
            Console.WriteLine(singleCharacter); 

        }

    }
}

