using System;

namespace LambdaEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first double number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second double number: ");
            double num2 = double.Parse(Console.ReadLine());

            //Create a lambda expression that adds the numbers.
            var add = (double a, double b) =>
            {
                var addCalc = a + b;
                return addCalc;
            };
            Console.WriteLine($"The sum of {num1} and {num2} is: {add(num1, num2)}");

            // Create a lambda expression that multiplies the numbers.
            var product = (double a, double b) => a * b;
            Console.WriteLine($"The product of {num1} and {num2} is: {product(num1, num2)}");

            //Create a lambda statement that compares the 2 numbers and returns the smaller value.
            var smallerNum = (double a, double b) =>
            {
                if (a < b)
                {
                    return a + " is the smaller number";
                }
                else
                {
                    return b + " is the smaller number";
                }
            };
            Console.WriteLine(smallerNum(num1, num2));

            //Use each of the lambda expressions in a Console.WriteLine statement

        } //end main
    } //end program
}//end namespace
