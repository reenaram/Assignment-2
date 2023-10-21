using System;

namespace Question_03
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Write a program to calculate the area of a circle.
            The user will enter the radius of the circle
            and the program will calculate and display the area according to the formula
            (area = 3.14 * radius * radius).
            You must accept fractions as the input.
            If the user enters 1.2 for the radius then the area will be 4.52.
            (Use the "F" format-specifier for floating point values).

            input
            radius of the circle 

            processing
            prompt user to enter radius of the circle
            read and store user's input
            use input in formula (area = 3.14 * radius * radius)
            display area using the "F" format specifier

            output
            calculated area

            */

            // declare variables

            double radius;
            double area;

            // collect inputs

            Console.WriteLine("Enter radius of the circle:");

            // algorithm
            radius = Convert.ToDouble(Console.ReadLine());
            area = 3.14 * radius * radius;

            // display results 

            Console.WriteLine($"The area of the circle is: {area:F2}");

        }
    }
}

