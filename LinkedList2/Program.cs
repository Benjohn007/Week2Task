using System;

namespace LinkedList2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkList<string> now = new LinkList<string>();


            Node<string> ll2 = new Node<string>("three");
            now.Addhead(ll2);

            Node<string> ll1 = new Node<string>("two");
            now.Addhead(ll1);

            Node<string> ll = new Node<string>("one");
            now.Addhead(ll);
            Console.WriteLine("The current index is: " + now.Index("one"));


            now.print();



           //checking and removing item

            Node<string> target = now.Check("one");
           if (target != null)
            {
                Console.WriteLine("\n\nfound " + target.Data);
            }
            else
            {
                Console.WriteLine("Nothing here");
            }

            Console.WriteLine("\nRemoving " + target.Data);
            now.RemoveFirst();
            now.print();







           

        }
    }
}
