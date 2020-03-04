
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCode
{
    class Program
    {
        static void Main(string[] args)
        {
            

            ////Binary Tree
            ////ASCII characters table: https://www.dotnetperls.com/ascii-table
           
            BinaryTree binaryTree = new BinaryTree();
            binaryTree.InsertTree(binaryTree.data);
            binaryTree.Display();
            Console.WriteLine();



            

        }
    }
}
