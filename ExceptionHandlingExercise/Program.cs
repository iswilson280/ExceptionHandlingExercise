using System;
using System.Collections.Generic;
using System.IO;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            // Create a list called numbers that will hold integers //1 do this first


            // Create an string variable with an empty string initializer - name it str

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:

            // Make a foreach loop to iterate through your character array

            char[] characters = { 'I', 's', 'a', 'i', 'a', 'h', '2','4','6' };
             List<int> numbers = new List<int>();

            foreach (char c in characters)
            {
                Console.WriteLine(c);
            }




            // Now create a try catch

            foreach (char c in characters)
            {

                try
                {
                    string str = c.ToString();
                    int number = int.Parse(str);      //parse str into an integer
                    numbers.Add(number);
                    // Console.WriteLine(str)
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Unable to Parse '{c}'");
                }



            }


            
            


            // Inside your try block
            // set your string variable to each array element in your char[] to .ToString()
            // Now, using int.Parse, parse your string variable and store in an int variable -- 1. do this second
            // Then add each int to your list -- 3. do this third

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection



            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
