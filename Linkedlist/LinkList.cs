using SinghlyLinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class LinkList
    {
        // initiallize the private field
        private Node head;
        private int count;

        //create a constructure
        public LinkList()
        {
            this.head = null;
            this.count = 0;
        }

        //Size function
        public bool Empty
        {
            get { return this.count == 0; }
        }

        public int Count
        {
            get { return this.count; }
        }

        public object Add(int index, object o)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException("index " + index);

            if (index >= this.Count)
                index = Count;

            Node currentHead = this.head;

            if (this.Empty || index == 0)
            {
                this.head = currentHead;
            }
            else
            {
                for (int i = 0; i < index -1; i++)
                    currentHead = this.;
            }

        }
    }
}
