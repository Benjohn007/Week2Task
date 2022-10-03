using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    public class Queue<T>
    {
        public int Count = 0;
        public Node<T> front;
        public Node<T> rear;

        public void LinkedList()
        {
            this.front = null;
            this.rear = null;
        }

        public int Enqueue(T Data)
        {
            Node<T> temp = new Node<T>(Data);

            if (front == null) front = temp;
            else rear.Next = temp;

            rear = temp;
            Count++;
            return Count;
        }

        public T Dequeue()
        {
            if (Count == 0)
            throw new Exception("Emprty Queue");
            T Data = front.Data;

            if (front.Next == null)
                front = null;
            else front = front.Next;

            return Data;
        }

        public void Print()
        {
            Node<T> node = front;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }

        public bool isEmpty()
        {
            return front == null;
        }

        public int Size()
        {
            return Count;
        }
    }
}
