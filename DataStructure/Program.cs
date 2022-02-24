using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Data Structure Program");
                        
            LinkedList list = new LinkedList();
            list.Add(56);
            //list.Add(30);
            list.Add(70);
            list.Display();
            list.Insert(2, 30);
        }
    }
}