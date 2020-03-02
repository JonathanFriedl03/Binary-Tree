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
        public TreeNode link;
        //CTOR
        public TreeNode(int value)
        {
           data = value;
        }
        public void Add(int value)
        {
            //TreeNode node = new TreeNode(value);
 
            //{
                // if the value passed in is greater or equal to the data then add to the right node
                if (value >= data)
                { //if no node present create one
                    if (rightNode == null)
                    {
                    rightNode = new TreeNode(value);
                    }
                    else
                    {// if value isnt null keep calling add on right side
                       rightNode.Add(value);
                    }
                }
                else
                {//if value passed in is less than the data insert to the left
                    if (leftNode == null)
                    {//if no node is present create one
                    leftNode = new TreeNode(value);
                    }
                    else
                    {//if the left node is not null then keep calling add on the left side
                       leftNode.Add(value);
                    }
                    // temp = temp.link;
                }
               // temp.link = node;

        }


    }
}
