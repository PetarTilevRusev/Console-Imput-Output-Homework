using System;
/*Problem 4. Number Comparer

    Write a program that gets two numbers from the console and prints the greater of them.
    Try to implement this without if statements.

            Examples:
            a 	    b 	    greater
            5 	    6 	    6
            10 	    5 	    10
            0 	    0 	    0
            -5 	    -2 	    -2
            1.5     1.6 	1.6
 */
class NumberComparer
{
    static void Main()
    {
        double firstNumber;
        double seconNumber;
        Console.WriteLine("Number Comparer program!");
        Console.Write("First number: ");
        string userFirstImput = Console.ReadLine();
        Console.Write("Second number: ");
        string userSecondImput = Console.ReadLine();

        if (double.TryParse(userFirstImput, out firstNumber) &&
            double.TryParse(userSecondImput, out seconNumber))
        {
            if (firstNumber >= seconNumber)
            {
                Console.WriteLine("The greater number is: {0}", firstNumber);
            }
            else
            {
                Console.WriteLine("The greater number is: {0}", seconNumber);
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid numbers!");
        }
    }
}

