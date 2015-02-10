using System;
                /*Problem 7. Sum of 5 Numbers
                
                    Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
                
                        Examples:
                        numbers 	        sum
                        1 2 3 4 5 	        15
                        10 10 10 10 10 	    50
                        1.5 3.14 8.2 -1 0 	11.84*/
class SumOfFiveNumbers
{
    static void Main()
    {
        Random randomValuie = new Random();
        int[] numbers = { randomValuie.Next(1, 1000), randomValuie.Next(1, 1000), randomValuie.Next(1, 1000), randomValuie.Next(1, 1000), randomValuie.Next(1, 1000) };

        int result = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4];
        Console.WriteLine("{0} + {1} + {2} + {3} + {4} = {5}",numbers[0], numbers[1], numbers[2], numbers[3], numbers[4], result);
    }
}

