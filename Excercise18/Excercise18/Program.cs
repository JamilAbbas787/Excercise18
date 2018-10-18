using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise18
{
    class Program
    {
         public static void Main(string[] args)
        {

            Console.Write("Enter a number: ");
            string userEntry = Console.ReadLine();

            bool entryCheck = int.TryParse(userEntry, out int userNumber);
            var combinedAnswer = 0;

            for (int i = 1; i <= userNumber; i++)
            {
                combinedAnswer = combinedAnswer + i;
                Console.WriteLine(combinedAnswer);

            }

            Console.Write("Would you like to continue (y/n): ");
            string continueQuestion = Console.ReadLine();
        

            if (continueQuestion.Equals("y",StringComparison.OrdinalIgnoreCase))
                {
                while (continueQuestion.Equals("y", StringComparison.OrdinalIgnoreCase))
                {
                    Console.Write("Enter a number: ");
                    userEntry = Console.ReadLine();

                    entryCheck = int.TryParse(userEntry, out userNumber);
                    combinedAnswer = 0;
                    for (int i = 1; i <= userNumber; i++)
                    {
                        combinedAnswer = combinedAnswer + i;
                        Console.WriteLine(combinedAnswer);

                    }

                    Console.Write("Would you like to continue (y/n): ");
                    continueQuestion = Console.ReadLine();
                    continue;
                }
                Console.WriteLine("GoodBye!!");
            }
            else if (continueQuestion.Equals("n", StringComparison.OrdinalIgnoreCase))
                {
                Console.WriteLine("GoodBye!!");
                }
            else
                {
                Console.WriteLine("Invalid Entry, GoodBye!!");
                }


            

            Console.ReadKey(); 
        }
             
    }
    
}
