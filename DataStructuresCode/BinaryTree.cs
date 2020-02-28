using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresCode
{
    class BinaryTree
    {
        Node topTree;
        Node LeftTree;
        Node RightTree;
        public BinaryTree()
        {
            
        }
        public void InsertDataRoot(int data)
        {
            Node node = new Node(data);
            if (topTree == null)
            {
                topTree = node;
                return;
            }

        }
        public void InsertDataLeft(int data) 
        {
            Node temp = topTree;
            while (temp.link != null)
            {
                temp = temp.link;
            }
            temp.link = LeftTree;
         





        }


    }
}
