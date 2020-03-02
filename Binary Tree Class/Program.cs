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
            binaryTree.Add(45);
            binaryTree.Add(25);
            binaryTree.Add(40);
            binaryTree.Add(80);
            binaryTree.Add(22);
            binaryTree.Add(48);
            binaryTree.Add(72);
            binaryTree.Add(74);
            binaryTree.Add(15);
           binaryTree.Search(15);
        }
    }
}
