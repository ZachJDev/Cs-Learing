namespace LinkedList
{
    public class LinkedList
    {
        // I wanted to see if I could implement an indexer by iterating over a list.
        // It seems like it works! But this is not a real LinkedList implementation and should
        // Not be used as such.
        public ListNode Head { get; set; }


        public LinkedList(Node head)
        {
            Head = new ListNode(head);
        }

        public string this[string id]
        {
            get
            {
                ListNode current = Head;
                if (Head.NodeId == id) return Head.NodeInfo;
                do
                {
                    current = current.Next;
                    if (current.NodeId == id) return current.NodeInfo;
                } while (current.Next != null);

                return null;
            }
        }
    }
}