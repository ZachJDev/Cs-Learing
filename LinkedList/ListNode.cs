namespace LinkedList
{
    public class ListNode
    {
        public ListNode Next { get; set; }
        public Node Node { get; }


        public ListNode()
        {
            Next = null;
        }
        public ListNode(Node node)
        : this()
        {
            Node = node;
        }

        public ListNode(string id, string info) : this()
        {
            Node = new Node(id, info);
        }
        
        public string NodeId
        {
            get => Node.NodeId;
            set => Node.NodeId = value;
        }

        public string NodeInfo
        {
            get => Node.NodeInfo;
            set => Node.NodeInfo = value;
        }
    }
}