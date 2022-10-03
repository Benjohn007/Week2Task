using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList2
{
    public class Node<T>
    {

        //create data
        public T Data { get; set; }

        //create link
        public Node<T> Next { get; internal set; }

        public Node(T data)
        {
            this.Data = data;
        }


    }
}
