using System;
/*Problem 5. Formatting Numbers

    Write a program that reads 3 numbers:
        integer a (0 <= a <= 500)
        floating-point b
        floating-point c
    The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
        The number a should be printed in hexadecimal, left aligned
        Then the number a should be printed in binary form, padded with zeroes
        The number b should be printed with 2 digits after the decimal point, right aligned
        The number c should be printed with 3 digits after the decimal point, left aligned.

            Examples:
            a 	    b 	         c 	        result
            254     11.6 	     0.5 	    FE |0011111110| 11.60|0.500 |
            499     -0.5559      10000 	    1F3 |0111110011| -0.56|10000.000 |
            0 	    3 	         -0.1234 	0 |0000000000| 3|-0.123 |*/
class FormattingNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter your numbers!");
        int[] userNumber = new int[4];

        for (int i = 1; i < 4; i++)
        {
            Console.Write("Number {0}: ", i);
            userNumber[1] = int.Parse(Console.ReadLine());
        }

        string binaryForm = Convert.ToString(userNumber[1], 2).PadLeft(31, '0');
        string twoDigits = string.Format("{0:0.00}", userNumber[2]);
        Console.WriteLine("The binary form of {0} is: {1}", userNumber[1],binaryForm);
        Console.WriteLine("The number {0} with two digits after the decimal point is: {1}", userNumber[2], twoDigits);

    }
}

