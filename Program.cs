using System;

namespace ConvertFeettoCentimeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Write a C# program convert a person's height (in feet and inches) to centimeters.
            
            Ex)
            feet = 5
            inches = 7
            output: 170.18 cm
            
            Formula:
            1 inch = 2.54 cm
            1 feet = 12 inches
            */

            //Intro
            Console.WriteLine("The purpose of this app is to convert someone's height from imperial foot/inch to centimeters.\n");

            //Get users height using the standard imperial format (Ex 5 foot 7 inches, or 6 foot 2)

            Console.WriteLine("Please enter your height to the nearest foot. For example, if you are 5'7'', you would enter 5 for the feet.");
            int heightToNearestFoot = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter any additional inches to your height. For example, if you are 5'7'', you would enter 7 for the inches.");
            int additionalInchesToHeight = Convert.ToInt32(Console.ReadLine());

            //Equations to convert inches to centimeters
            int userHeightInInches = (heightToNearestFoot * 12) + additionalInchesToHeight;
            double userHeightInCentimeters = userHeightInInches * 2.54;

            Console.WriteLine($"Your height in centimeters is {userHeightInCentimeters}.");

        }
    }
}
