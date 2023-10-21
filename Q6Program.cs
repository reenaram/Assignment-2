using System;

namespace Question06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            Write a program to calculate and display the potential difference
            between the ends of a wire.

            The program will prompt the user for the current flowing
            and the resistance of the wire.

            Potential difference is the product of the current
            and the resistance of the wire and may include a fractional part.

            (Again, use the "F" format-specifier for floating point values).

            input
            current
            resistance

            processing
            prompt user input for current and resistance
            read and store user input
            calculate potential different (current multiplied by resistance)
            display product

            output
            display product

            */

            // declare variables
            double current;
            double resistance;
            double potentialDifference;

            // input
            Console.WriteLine("To calculate potential difference, input the current flowing and the resistance of the wire.");
            Console.WriteLine("Enter current: ");            current = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter resistance: ");
            resistance = Convert.ToDouble(Console.ReadLine());

            // algorithm
            Console.WriteLine("Current x Resistance = Potential Difference.");
            potentialDifference = current * resistance;

            // display
            Console.WriteLine($"Therefore, the potential difference is: {potentialDifference:F2}.");

        }
    }
}

