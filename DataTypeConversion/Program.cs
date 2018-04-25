using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring & assigning value to the int and long
            //int is 32 bit and long is 64 bit
            int number = 2323;
            long bigNumber = 12;
            string inputNumber = "28374"; 

            //assigning the value of 'number' to the 'bigNumber'
            //so the bignumber = 2323 now
            bigNumber = number;

            number = Convert.ToInt32(bigNumber); //convert work with everything

            number = (int)bigNumber; //casting work with compatible type

            //number = (int)inputNumber; //won't work

            number = int.Parse(inputNumber); //Parse work with only string

            //number = int.Parse(bigNumber); // won't work

            Console.WriteLine("Your Parsed integer number is: " + number);
            Console.WriteLine();

            Console.WriteLine("Let's take value from the user and convert it to the integer");
            Console.WriteLine();

            Console.WriteLine("Please enter some number & then hit enter:");
            //taking value from the user, then converting it to integer & assigning it to the variable called 'userNumber'
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Your converted number is: " + userNumber);
            Console.ReadKey();



        }
    }
}
