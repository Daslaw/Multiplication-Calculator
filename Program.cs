using System;

namespace multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaration of Values
            int firstNumber = 0;
            int secondNumber = 0;
            int thirdNumber = 0;
            int multResult= 0;
            // Request for values from the respondent
            Console.WriteLine("Enter your first Number: ");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Second Number: ");
            secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Third Number: ");
            thirdNumber = int.Parse(Console.ReadLine());

            // Multsiplication and Displays of Result
            multResult = firstNumber * secondNumber * thirdNumber;  
            Console.WriteLine("The result is: "+ multResult);
        }
    }
}
