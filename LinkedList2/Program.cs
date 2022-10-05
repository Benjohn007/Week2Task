using System;

namespace LinkedList2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*LinkList<string> now = new LinkList<string>();


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
            now.print();*/


            //QUEUE

            /* Queue<int> queue = new Queue<int>();
             queue.Enqueue(1);
             queue.Enqueue(2);
             queue.Enqueue(3);

             bool a = queue.isEmpty();
             int b = queue.Size();
             queue.Print();
             Console.WriteLine(a);
             Console.WriteLine(b);  
             Console.WriteLine("\n");

             int removeItem = queue.Dequeue();
             Console.WriteLine(removeItem);
             Console.WriteLine("\n");
             queue.Print();*/



            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(3);
            stack.Push(2);
            stack.Push(4);

            Console.WriteLine(stack.Size());
            stack.Pop();
            stack.Pop();
            stack.empty();

          

            stack.Size();

            int peekValue = stack.Peek();
            Console.WriteLine(peekValue);

           

            Console.WriteLine(stack.Size());

            bool isEmpty = stack.IsEmpty();
            Console.WriteLine(isEmpty);

            stack.Display();
        }
    }
}
