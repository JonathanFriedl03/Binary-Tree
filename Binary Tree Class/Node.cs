using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Class
{
    class Node
    {
        public Node left;
        public Node right;
        int data;
        public Node link;

        public Node(int data)
        {
            this.data = data;
        }
    }
}
