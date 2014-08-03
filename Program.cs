using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Eric";
            string lastName = "Schles";

            Console.WriteLine("Name: " + firstName + " " + lastName);

            Console.WriteLine("Please enter a new first name:");
            firstName = Console.ReadLine();
            Console.WriteLine("Please enter a new last name:");
            lastName = Console.ReadLine();
            Console.WriteLine("New name: " + firstName + " " + lastName);
            Console.ReadLine();
        }
    }
}
