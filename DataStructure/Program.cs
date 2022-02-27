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
            list.Add(40);
            list.Add(70);
            int position = list.Search(40);
            list.DeleteNodeAtParticularPosition(position);
            Console.WriteLine("\nAfter deleting 40: ");
            list.Size();
            list.Display();

        }
    }
}