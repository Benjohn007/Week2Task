using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    public class Stack<T>
    {
        public Node<T> Top;
        public int Count = 0;

        public void Linklist()
        {
           this.Top = null;
        }


        public int Push(T Data)
        {
            Node<T> temp = new Node<T>(Data);

            if (temp == null)
            {
                Console.WriteLine("\nHeap Overflow");
            }

            temp.Data = Data;
            temp.Next = Top;
            Top = temp;
            Count++;
            return Count;
        }

        public bool IsEmpty()
        {
            return Top == null;
        }

        public T Peek()
        {
            if (!IsEmpty())
            {
                return Top.Data;
            }
            else
            {
                throw new Exception("Stack is Empty");
            }
        }

        public void Pop()
        {
            if (Top == null)
            {
                throw new Exception("Stack Underflow");
            }
            Top = Top.Next;
            Count--;
        }

        public void Display()
        {
            if (Top == null)
            {
                Console.WriteLine("\nStack Underflow");
                return;
            }
            else
            {
                Node<T> temp = Top;
                while (temp != null)
                {
                Console.WriteLine("{0}-->", temp.Data);
                temp = temp.Next;
                }
            }
        }

        public bool empty()
        {
            return Count == 0;  
        }
        public int Size()
        {
            return Count;
        }
    }
}
