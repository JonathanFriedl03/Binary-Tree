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
        TreeNode tail;

        public void Add(int data)
        {
            //if the root is not null then we call the Insert method on the root node
            if (start != null)
            {
                start.Add(data);
            }
            else
            {//if the root is null then we set the root to be a new node based on the data passed in
                start = new TreeNode(data);
            }
        }

        //public void Add(int value)
        //{
        //    TreeNode node = new TreeNode(value);
        //   //create initial node
        //    if (start == null)
        //    {
        //        start = node;
        //        return;
        //    }
        //    TreeNode temp = start;
        //        while (temp.link != null)
        //     {
        //        // if the value passed in is greater or equal to the data then add to the right node
        //        if (value >= node.Data)
        //        { //if no node present create one
        //            if (node.Right == null)
        //            {
        //                node.Right = new TreeNode(value);
        //            }
        //            else
        //            {// if value isnt null keep calling add on right side
        //                Add(value);
        //            }
        //        }
        //        else
        //        {//if value passed in is less than the data insert to the left
        //            if (node.Left == null)
        //            {//if no node is present create one
        //                node.Left = new TreeNode(value);
        //            }
        //            else
        //            {//if the left node is not null then keep calling add on the left side
        //                Add(value);
        //            }
        //            // temp = temp.link;
        //        }
        //        temp.link = node;
            
        //    }


        //}
        //public int Search(int value)
        //{
        //    //start or first node
        //    int searchedNode = value;

        //    //loop through this node and all children
        //    while (searchedNode != null)
        //    {
        //        //if value of specific node is equal to value passed in return it
        //        if (value == searchedNode.data)
        //        {
        //            return searchedNode;
        //        }
        //        //if the value passed in is greater than the specific data then go to right child
        //        else if (value > searchedNode.data)
        //        {
        //            searchedNode = searchedNode.right;
        //        }
        //        //otherwise if the value passed in is less than the specific data then go left child
        //        else
        //        {
        //            searchedNode = searchedNode.Left;
        //        }

        //    }//node not found
        //    return null;

        //}
    }
  

    //public void Add(int data)
    // {
    //     TreeNode node = new TreeNode(data); //10
    //     if (start == null)
    //     {
    //         start = node;
    //         return;
    //     }
    //     tail.link = node; //public void InsertAtEnd(int data)
    //     //{
    //     //    Node node;
    //     //    Node temp = new Node(data);
    //     //    if (start == null)
    //     //    {
    //     //        start = temp;
    //     //        return;
    //     //    }
    //     //    node = start;
    //     //    while (node.link != null)
    //     //    {
    //     //        node = node.link;
    //     //    }
    //     //    node.link = temp;
    //     //}

    //     //Node temp = start; //7
    //     //while (temp.link != null)
    //     //{
    //     //    temp = temp.link;
    //     //}
    //     //temp.link = node;
    // }
}

