namespace LinkedList
{
    public class ListNode
    {
        public ListNode Next { get; set; }
        private Node Node { get; }



        public ListNode(Node node)
        {
            Node = node;
        }

        public ListNode(string id, string info)
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