using SinglyLinkedList;
using System;

namespace SinghlyLinkedList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           LinkList now = new LinkList();

            Console.WriteLine("is empty " + now.Empty);
            Console.WriteLine("Count == " + now.Count);
            Console.ReadLine();
        }
    }
}
