using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinghlyLinkedList
{
    public class Node
    {

        class LinkedListNode
        {
            private object data;
            private Node next;


            //create a constructor
            public LinkedListNode(object data, Node next)
            {
                this.data = data;
                this.next = next;
            }

            //create the properties
            public object Data
            {
                get { return this.data; }
                set { this.data = value; }
            }

            public Node Next
            {
                get { return this.next; }
                set { this.next = value; }
            }
        }
        
        
    }
}
