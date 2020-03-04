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
        int nodeInputValue;
        public int data;

        public BinaryTree()
        {
            
        }
        public void InsertTree(int data)
        {
            Node node = new Node(data);
            data = nodeInputValue;


            if (topTree == null)
            {
                topTree = node;
                //nodeTopValue = data;

                
            }
            Node temporary = topTree;
            while (temporary.link != null && nodeInputValue > data)
            {
                temporary = temporary.linkLeft;
                temporary.linkLeft = node;
                if (nodeInputValue > data)
                {

                }
                
            }

            while (temporary.link != null && nodeInputValue < data)
            {
                temporary = temporary.linkRight;
                temporary.linkRight = node;
                
            }
   
            
        }
        // Need to link left or right without having more than two Nodes, One Node per level 
        // is acceptabe

        public void AssignNodes()
        {
         
        }


        public void DisplayTree()
        {
            Console.WriteLine(topTree);
            Console.ReadLine();
        }

        
    }


    
}
