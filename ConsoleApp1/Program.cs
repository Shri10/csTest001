using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings Universe !!!");

            Human human1 = new Human();

            Console.WriteLine("Please enter your Name:");
            human1.name = Console.ReadLine();
            Console.WriteLine("Please enter your Height:");
            human1.height = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Please enter your Phone Number:");
            human1.phone = long.Parse(Console.ReadLine());

            human1.HumanDetails();

            /*Console.WriteLine("This is Shriraj.");
            Console.WriteLine("A participant of BL.");
            Console.WriteLine("Remote line modified.");
            Console.WriteLine("Modified in local.");*/
            Console.ReadLine();
        }
    }
}
