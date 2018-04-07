using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            //decclaraing type and assigning value
            int number = 12;
            double number2 = 12.13;
            char alphabet = 'A';
            string sentence = "Hello World";

            //showing all the variable's value
            Console.WriteLine(number + " is a integer type value,");
            Console.WriteLine(number2 + " is a double type value,");
            Console.WriteLine(alphabet + " is a charater type value &");
            Console.WriteLine(sentence + " is a string type value");

            //Console.WriteLine(); is just to enter exra line in the middle of the code
            Console.WriteLine();
            Console.WriteLine("Let's now take value from the user!");
            Console.WriteLine();

            
            Console.WriteLine("Please write something from the keyboard and hit enter: ");
            //taking value from the user & assigning it to the variable
            string sentence2 = Console.ReadLine();
            Console.WriteLine();
            
            //showing the user's defined value back to the console screen
            Console.WriteLine("So you typed '" + sentence2 +"' from the keyboard");
            Console.ReadKey();            
        }
    }
}
