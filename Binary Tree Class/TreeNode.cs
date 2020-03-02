using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Class
{
    class TreeNode
    {
        private int data;
        public int Data
        {
            get { return Data; }
            set { data = value; }
        }
        private TreeNode left;       
        public TreeNode Left
        {
            get { return left; }
            set { left = value; }
        }

        private TreeNode right;
        public TreeNode Right
        {
            get { return right; }
            set { left = value; }
        }
        public TreeNode link;
        //CTOR
        public TreeNode(int value)
        {
           data = value;
        }
       

    }
}
