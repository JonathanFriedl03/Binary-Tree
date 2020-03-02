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
            get { return data; }
            set { data = value; }
        }
        private TreeNode leftNode;       
        public TreeNode LeftNode
        {
            get { return leftNode; }
            set { leftNode = value; }
        }

        private TreeNode rightNode;
        public TreeNode RightNode
        {
            get { return rightNode; }
            set { rightNode = value; }
        }
        
        //CTOR
        public TreeNode(int value)
        {
           data = value;
        }
        //public void Add(int value)
        //{
        //    //TreeNode node = new TreeNode(value);

        //    //{
        //    // if the value passed in is greater or equal to the data then add to the right node

        //    // temp.link = node;

        //}


    }
}
