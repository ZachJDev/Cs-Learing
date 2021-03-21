namespace StackOverflowPost
{
    public class Post
    {
        public int Votes { get; private set; }
        public string Description { get; set; }
        public string Title { get; set; }

        public Post( string title, string description)
        {
            Description = description;
            Title = title;
        }
        
        public Post UpVote()
        {
            ++Votes;
            return this;
        }

        public Post DownVote()
        {
            --Votes;
            return this;
        }

    }
}