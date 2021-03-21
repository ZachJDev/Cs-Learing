using System;

namespace LinkedList
{
    public class Node
    {
        public string NodeId { get; set; }
        public string NodeInfo { get; set; }

        public Node(string id, string info)
        {
            NodeId = id;
            NodeInfo = info;
        }
        
    }
}