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
            list.Display();

            int a = list.Search(30);
            a++;
            list.InsertAtParticularPosition(a + 1, 40);
            list.Add(40);
            list.Display();

        }
    }
}