using CSharp.DataStructure;

namespace CSharp.LinkedList
{
    public class SingleLinkedList
    {
        public Node? Head;

        public void Add(int Data)
        {
            Node nodeItem = new(Data);
            if (Head == null) { Head = nodeItem; }
            else
            {
                Node Current = Head;
                while (Current.Next != null)
                {
                    Current = Current.Next;
                }
                Current.Next = nodeItem;
            }
        }

        public static int FindMiddleIndexFromNodeList(Node Node)
        {
            if (Node == null) { throw new Exception(); }

            List<int> list = new();

            Node Current = Node;

            while (Current != null)
            {
                list.Add(Current.Data);
                Current = Current.Next!;
            }

            int middleIndex = list.Count / 2;
            return list[middleIndex];
        }
    }
}
