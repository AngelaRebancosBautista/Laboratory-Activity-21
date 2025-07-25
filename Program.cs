using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory_Activity_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("[1] Greet");
                Console.WriteLine("[2] Show Date");
                Console.WriteLine("[3] Exit");
                Console.Write("Please enter your choice (1-3): ");

                string input = Console.ReadLine();

                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Hello, User!");
                            break;
                        case 2:
                            Console.WriteLine("Current Date: " + DateTime.Now.ToString("yyyy-MM-dd"));
                            break;
                        case 3:
                            Console.WriteLine("Exiting..");
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                        }
                    }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                }
                Console.WriteLine(); 
            } while (choice != 3);
        }
    }
}
            

 

