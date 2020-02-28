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
        public void InsertDataTree(int data)
        {
            Node node = new Node(data);
            if (topTree == null)
            {
                topTree = node;
                return;
            }
            Node temporary = topTree;
            while (temporary.linkLeft != null)
            {
                temporary = temporary.linkLeft;
                
            }
            temporary.linkLeft = node;
        }

        
    }


    
}
