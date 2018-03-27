using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequencyDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            
            bool stopInput = false;
            string input;
            int result;
            string allInput = "";


            while (!stopInput)
            {
                bool validInput = false;

                do
                {
                    Console.WriteLine("Please enter a number between 0 and 10 OR press Q to finish.");

                    input = Console.ReadLine();

                    if (Int32.TryParse(input, out result))
                    {
                        if (result >= 0 && result <= 10)
                        {
                            validInput = true;
                            allInput += input + ",";
                        }
                    }

                    if (input.ToUpper().Equals("Q"))
                    {
                        validInput = true;
                        stopInput = true; // Need this to exit the input loop. 
                    }

                    if(!validInput)
                        Console.WriteLine("Invalid Input. The value won't counted.");

                } while (!validInput);
            }

            string[] numbers = allInput.Split(',');

            for (int i = 1; i < 10; i++)
            {
                Console.Write("\n" + i + "  "); // This makes 1 through 10 on the left side

                for (var j = 0; j < numbers.Length -1; j++) // THis second for loop goes through the numbers array. 
                {
                    // Try to find all 1s first, then try to match the asterisk, then so forth
                    if (Convert.ToInt32(numbers[j]) == i) // This if looks for whatever is in the numbers array. If it is equal to i, then it shoots out an asterisk. [111213231]. 
                    {
                        Console.Write("*");
                    }
                }
            }



        }
    }
}
