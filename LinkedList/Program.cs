using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList(new Node("Beal", "Greenish"));
            list.Head.Next = new ListNode("teal", "Blueish");
            Console.WriteLine(list["teal"]);
        }
        
    }
}