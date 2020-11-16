/* This code is free code void of copyright,
it will be used to count an amount of numbers with
a certain amount of digits*/
using System;

class Digits
{
    static void Main()
    {
        int singleDigitCounter = 0, twoDigitsCounter = 0, threeDigitsCounter = 0, bigDigitsCounter = 0;
       
        Console.Write("Insert a number \"end\" to finish: ");
        string userInput = Console.ReadLine();
        
        while(userInput != "end")
        {
            /* This part can be improved by adding error control
            to the string to integer conversion*/
            int number = Convert.ToInt32(userInput);

            if (number != 0)
            {
                if (number / 10 == 0)
                    singleDigitCounter ++;

                else if (number / 100 == 0)
                    twoDigitsCounter ++;

                else if (number / 1000 == 0)
                    threeDigitsCounter ++;

                else
                    bigDigitsCounter++;
            }
            Console.Write("Insert a number \"end\" to finish: ");
            userInput = Console.ReadLine();
        }
        
        Console.WriteLine("One digit numbers: {0} Two digit numbers: {1} Three digit numbers: {2} More than four digit numbers: {3}",
        singleDigitCounter, twoDigitsCounter, threeDigitsCounter, bigDigitsCounter);
    }
}