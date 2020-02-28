using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Class
{
    class Binary_Tree
    {
        Node start;
        Node tail;

        public bool Search(Node data)
        {
            if (//data value< this node go left)
            {

            }
            if (//data value >= this node go right)
            {

            }
        }

        public void InsertAtEnd(int data)
        {
            Node node = new Node(data); //10
            if (start == null)
            {
                start = node;
                return;
            }
            node.link = tail;

            //Node temp = start; //7
            //while (temp.link != null)
            //{
            //    temp = temp.link;
            //}
            //temp.link = node;
        }
    }
}
