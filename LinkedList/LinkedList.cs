namespace LinkedList
{
    public class LinkedList
    {

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