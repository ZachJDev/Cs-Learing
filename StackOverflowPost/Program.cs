using System;

namespace StackOverflowPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p = new Post("How do I make a Class in C#?", "I've been trying all day!");
            p.UpVote();                   //   1 Vote
            p.UpVote().UpVote().UpVote(); //+  3 Votes
            p.DownVote().DownVote();      //-  2 Votes
                                          // _________
            Console.WriteLine(p.Votes);   //   2 Votes
        }
    }
}
