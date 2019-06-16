using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorials
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt user for a number
            Console.WriteLine("Enter a number to retrieve it's factorials: ");
            int userInput = Convert.ToInt32(Console.ReadLine()); //accept user input assuming a valid int is provided

            //invoke get factorials method
            GetFactorials(userInput);
            Console.Read();
        }

        private static void GetFactorials(int userInput)
        {
            //set product to 1 initially and not 0
            int product = 1;

            //Create a string builder for building the factorial string 
            StringBuilder sb = new StringBuilder();
             
            //start the string builder with the user's number input
            sb.Append(userInput + "!=");

            //loop and get every number below the user's input
            for(int i = userInput - 1; i > 0; i--)
            {
                if (i == 1)
                {
                    sb.Append(i + "=");
                }
                else
                {
                    sb.Append(i + "*");
                }
               
                product *= i;
            }

            //calculate the product of numbers looped multiplied by the number supplied
            product = (product * userInput);

            //Write to console the stringbuilder as the message containing the factorials and product
            Console.Write(sb.Append(product));
        }
    }
}
