using System;
                /*Problem 1. Sum of 3 Numbers
                
                    Write a program that reads 3 real numbers from the console and prints their sum.
                
                        Examples:
                        a 	    b 	    c 	    sum
                        3 	    4 	    11 	    18
                        -2 	    0 	    3 	    1
                        5.5     4.5    	20.1 	30.1*/

class SumOfThreeNumbers
{
    static void Main()
    {
        double firstNumber;         //First I create the variables to hold userImput values
        double secondNumber;
        double thirdNumber;
        Console.WriteLine("Now I will calculate a fiew numbers for you!"); //Teling the user what is going on

        //Taking the user imputs
        Console.Write("\nFirst number: ");
        string userFirstImput = Console.ReadLine();
        Console.Write("\nSecond number: ");
        string userSecondImput = Console.ReadLine();
        Console.Write("\nThird number: ");
        string userThirdImput = Console.ReadLine();

        //Checking the user imputs. Are they numbers to avoid error!
        if (double.TryParse(userFirstImput, out firstNumber) &&
            double.TryParse(userSecondImput, out secondNumber)&&
            double.TryParse(userThirdImput, out thirdNumber))
        {
            //Calculating and printing
            double result = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine("\n{0} + {1} + {2} = {3}", firstNumber, secondNumber, thirdNumber, result);
        }
        else
        {
            Console.WriteLine("Please enter a valid numbers!"); //Teling the user that his numbers are invalid.
        }
    }
}

