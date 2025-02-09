using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.DataStructure
{
    public class Node
    {
        public int Data;
        public Node? Next;

        public Node(int item)
        {
            this.Data = item;
            this.Next = null;
        }
    }
}
