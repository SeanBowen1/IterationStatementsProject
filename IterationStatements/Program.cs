using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a List called "numbers"
            //Create a variable of type int with an initializer of 0
            var numbers = new List<int>();
            var i = 0;
            do
            {
                i++;
                numbers.Add(i);

            } while (i > 100);

            // Create a do-while loop
            
                // Increment your variable by 1
                // Then add your variable to "numbers"
            
            // While your variable is less than 100

            
            while (i > 200) i++;
            numbers.Add(i);

            // Create a while loop
            // While your variable is less than 200
            {
                // Increment your variable by 1
                // Then add your variable to "numbers"
            }

            Console.WriteLine("Increase:");
            foreach (var num in numbers) 
            {
                Console.WriteLine(num);

            }



                Console.WriteLine("");
                Console.WriteLine("Decrease:");
            
            // Create a foreach loop
            // Write your variable to the console

            Console.WriteLine("");
            Console.WriteLine("Decrease:");
            
            for (var j = 199; j <= numbers.Count && j >= 0; i--)
            {
                Console.WriteLine(numbers[j]);
            } Console.WriteLine(numbers.Count);
            // Create a for loop
            // in your initializer set the value of i to 199
            // in your conditional, as long as i is less than or equal to the length of "numbers"
            // and as long as i is greater than or equal to 0
            // Decrement i by 1
            {
                // Write to the console "numbers" at index i
            }
        }
    }
}
