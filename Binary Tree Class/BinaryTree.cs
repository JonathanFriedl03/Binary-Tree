using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Class
{
    class BinaryTree
    {
        TreeNode start;
        

        public void Add(int data)
        {
            //if the root is null then we set the root to be a new node based on the data passed in
            if (start == null)
            {
                start = new TreeNode(data);
                
            }
            else
            {//if the root is not null then we call the Insert method on the root node
                TreeNode current = start;
                if (current.Data >= data)
                { //if no node present create one
                    if (current.RightNode == null)
                    {
                        current.RightNode = new TreeNode(current.Data);
                    }
                    else
                    {// if value isnt null keep calling add on right side
                        current.RightNode.Add(current.Data);
                    }
                }
                else
                {//if value passed in is less than the data insert to the left
                    if (current.LeftNode == null)
                    {//if no node is present create one
                        current.LeftNode = new TreeNode(current.Data);
                    }
                    else
                    {//if the left node is not null then keep calling add on the left side
                        current.LeftNode.Add(current.Data);
                    }                    
                }
            }
        }


        public int Search(int value)
        {

            //start or first node
            TreeNode searchedNode = start;

            //loop through this node and all children
            while (searchedNode == null)
            {
                //if value of specific node is equal to value passed in return it
                if (value == searchedNode.Data)
                {
                    return searchedNode;
                }
                //if the value passed in is greater than the specific data then go to right child
                else if (value > searchedNode.Data)
                {
                    searchedNode = searchedNode.RightNode;
                }
                //otherwise if the value passed in is less than the specific data then go left child
                else
                {
                    searchedNode = searchedNode.LeftNode;
                }

            }//node not found
            return null;

        }
}


     

