using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    public class Node
    {
        public int item;
        public Node leftc;
        public Node rightc;
        public Node(int data)
        {
            item = data;
            leftc = null;
            rightc = null;
        }
    }
}
