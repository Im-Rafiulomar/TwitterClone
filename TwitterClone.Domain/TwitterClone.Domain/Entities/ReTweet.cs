namespace TwitterClone.Domain.Entities
{
    public class ReTweet
    {
        private Guid _tweetId;
        private Guid _authorId;
        private string _content;

        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public Guid AuthorId
        {
            get { return _authorId; }
        }
        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }
    }
}
