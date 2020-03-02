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
        int nodeTopValue;
        public int data;
        public BinaryTree()
        {
            
        }
        public void CreateTree(int data)
        {
            
            Node node = new Node(data);
            
            if (topTree == null)
            {
                topTree = node;
                nodeTopValue = data;

                return;
            }
            Node temporary = topTree;
            if (temporary.linkLeft != null && nodeTopValue > data)
            {
                temporary = temporary.linkLeft;
                
            }
            temporary.linkLeft = node;
            if (temporary.linkRight != null && nodeTopValue < data)
            {
                temporary = temporary.linkRight;
            }
            temporary.linkRight = node;
        }
        public void DisplayTree()
        {
         
        }

        
    }


    
}
