using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    internal class Tree
    {
        Node root;
        public Tree()
        {
            root = null;
        }
        public Node returnroot()
        {
            return root;
        }
        public void Insert(int data)
        {
            Node newnode=new Node(data);
            if (root == null)
            {
                root = newnode;
            }
            else
            {
                Node current=root;
                Node paraent;
                while(true)
                {
                    paraent = current;
                    if (data < current.item)
                    {
                        current = current.leftc;
                        if(current==null)
                        {
                            paraent.leftc = newnode;
                            return;
                        }
                        
                    }
                    else
                    {
                        current = current.rightc;
                        if (current == null)
                        {
                            paraent.rightc = newnode;
                            return;
                        }
                    }
                }
            }
        }
        public void Display(Node root)
        {
            if(root != null)
            {
                Console.WriteLine(root.item + " ");
                Display(root.leftc);
                Display(root.rightc);
            }
        }
       
    }
}
