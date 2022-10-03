using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{

   /* public class Node<T>
    {

        //create data
        public T Data { get; set; }

        //create link
        public Node<T> Next { get; internal set; }

        public Node(T data)
        {
            this.Data = data;
        }


    }*/
    public class LinkList<T>
    {
        // initiallize the private field
        public Node<T> Head { get; private set; }
        public Node<T> Tall { get; private set; }
       public Node<T> Count { get; private set; }
      // public int Count = 0;

        public void LinkedList()
        {
            this.Head = null;
            this.Tall = null;
        }

        public void Addhead(Node<T> newHead)
        {
            if (this.Head == null)
            {
                this.Head = newHead;
                this.Tall = newHead;
            }
            else
            {
                newHead.Next = this.Head;
                this.Head = newHead;
            }
            //Count++;
        }

        public void Addtall(Node<T> newTall)
        {
            if (this.Head == null)
            {
                this.Head = newTall;
                this.Tall = newTall;
            }
            else
            {
                this.Head.Next = newTall;
                Tall = newTall;
            }
          // Count++;
            
        }


        public Node<T> Check(T target)
        {
            Node<T> currentData = Head;
            while (currentData != null && !currentData.Data.Equals(target))
            {
                currentData = currentData.Next;
            }
            return currentData;
        }


        public void RemoveFirst()
        {
            if (Head == null && this.Count == null)
            {
                return;

            }
            Head = Head.Next;
            this.Count = null;
        }

        public int Index(T item)
        {
            int index = 0;
            Node<T> currentData = Head;
            while(currentData != null)
            {
                if (item.Equals(currentData.Data))
                {
                    return index;
                }
                currentData = currentData.Next;
                index++;
            }
            return -1;
        } 

        public void print()
        {
            Console.WriteLine("\nFirst " + this.Head.Data);
            Console.WriteLine("\nLast " + this.Tall.Data);

            Node<T> node = this.Head;
            while (node.Next != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
            Console.WriteLine(node.Data);
        }

    }
 }
