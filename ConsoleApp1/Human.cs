using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Human
    {
        //This is another Branch
        public string name;
        public float height;
        public long phone;
        public void Talk()
        {
            Console.WriteLine("Hi, my name is  " + name);
        }
        public void HumanDetails()
        {
            Console.WriteLine("Name: {0}, height: {1}, Phone number: {2}", name, height, phone);
        }
    }
}
