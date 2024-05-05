using CSharp.DataStructure;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp.LinkedList
{
    public class SingleLinkedList
    {
        public required Node head;
        public void AddFirst (object data)
        {
            Node newItem = new()
            {
                data = data
            };
            newItem.next = head;
            head = newItem;
        }

        public void AddLast(object data)
        {
            Node newItem = new()
            {
                data = data
            };
            if (head == null)
            {
                head = newItem;
                head.next = null;
            }
            else
            {
                Node current = head;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = newItem;
                newItem.next = null;
            }
        }

        public void ReadAll()
        {
            Node current = head;
            while (current.next != null)
            {
                current = current.next;
                Console.WriteLine(current.data);
            }
        }
    }
}
