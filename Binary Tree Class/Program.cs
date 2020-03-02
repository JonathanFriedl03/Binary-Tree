using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(50);
            binaryTree.Add(65);
            binaryTree.InsertAtEnd(45);
            binaryTree.InsertAtEnd(25);
            binaryTree.InsertAtEnd(40);
            binaryTree.InsertAtEnd(80);
            binaryTree.InsertAtEnd(22);
            binaryTree.InsertAtEnd(48);
            binaryTree.InsertAtEnd(72);
            binaryTree.InsertAtEnd(74);
            binaryTree.InsertAtEnd(15);
        }
    }
}
