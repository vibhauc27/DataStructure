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
            list.Add(30);
            list.Add(70);
            int searchData = list.Search(30);

            if (searchData != 0)
                Console.WriteLine("\n{0} is present in the LinkedList ", searchData);
           
        }
    }
}