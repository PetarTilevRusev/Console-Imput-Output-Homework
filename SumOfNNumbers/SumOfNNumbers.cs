using System;
                /*Problem 9. Sum of n Numbers
                
                    Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.
                
                        Examples:
                        numbers 	sum
                        3 	        90
                        20 	
                        60 	
                        10 	
                        5 	        6.5
                        2 	
                        -1 	
                        -0.5 	
                        4 	
                        2 	
                        1 	        1
                        1 	
*/
class SumOfNNumbers
{
    static void Main()
    {
        Console.WriteLine("How many numbers are you going to enter?");
        Console.Write("Answer: ");
        int numbersToCalculate = int.Parse(Console.ReadLine());
        double[] userNumbers = new double[numbersToCalculate];
        double sum = 0;

        for (int i = 0; i < numbersToCalculate; i++)
        {
            Console.Write("Enter your number: ");
            userNumbers[i] = double.Parse(Console.ReadLine());
            sum = sum + userNumbers[i];
        }

        Console.WriteLine("Result: {0}",sum);
        
    }
}

