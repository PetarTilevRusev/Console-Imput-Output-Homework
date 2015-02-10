using System;
                /*Problem 3. Circle Perimeter and Area
                
                    Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
                
                            Examples:
                            r 	    perimeter 	area
                            2 	    12.57 	    12.57
                            3.5 	21.99 	    38.48
                */
class CirclePerimeterAndArea
{
    static void Main()
    {
        float  pi = 3.14f;
        float[] exampleRadius = { 2f, 3.5f }; //Using array to hold multiple values in one variable

        for (int i = 0; i < exampleRadius.Length; i++) //Looping every number in exampleRadius
        {
            //Calculating
            float perimeter = (2 * pi) * exampleRadius[i]; //Finding the perimeter of the circle
            float area = pi * (exampleRadius[i] * exampleRadius[i]); //Finding the area of the circle
            //Printing
            Console.WriteLine("Radius = {0} Perimeter = {1} Area = {2}", exampleRadius[i], perimeter, area); 
        }
        //User imput
        Console.WriteLine(new string('-', 80));
        Console.WriteLine("Do you wanna calculate your oun circle?"); //Asking the user
        Console.Write("Yes or No: "); //Posible answers
        string answer = Console.ReadLine(); //Taking the answer

        if (answer == "Yes" || answer == "yes") //Checking the answer Yes or yes
        {
            //Taking the radius from the user
            float radius; //Creating empty float to gold the user radius
            Console.Clear(); //Clearing the console
            Console.Write("Circle radius: ");
            string userRadius = Console.ReadLine(); //Taking the userRadius
            if (float.TryParse(userRadius, out radius)) //Making a check is the radius a number
            {
                //Calculating
                float perimeter = (2 * pi) * radius;
                float area = pi * (radius * radius);
                //Printing
                Console.WriteLine("Radius = {0} Perimeter = {1} Area = {2}", radius, perimeter, area);
            }
            else //If the userRadius isn't a number
            {
                Console.WriteLine("Wrong radius value!\nPlease try again!");
            }
        }
        else if (answer == "No" || answer == "no") //If the user answer is No or no
        {
            Console.WriteLine("Thank you, good bue!");
        }
        else //If the answer is something else
        {
            Console.WriteLine("Please enter a valid answer!");
        }
    }
}

