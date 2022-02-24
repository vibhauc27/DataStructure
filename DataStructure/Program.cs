using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Structure Program");
                        
            LinkedList list = new LinkedList();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //list.Display();

            list.AddReverse(70);
            list.AddReverse(30);
            list.AddReverse(56);
            Console.WriteLine("Display Nodes are");
            list.Display();
        }
    }
}