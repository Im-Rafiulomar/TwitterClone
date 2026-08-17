namespace TwitterClone.Domain.Entities
{
    public class ReTweet
    {
        private Guid _id; // Class unique id
        private Guid _tweetId;
        private Guid _authorId;
        private string _content;
        private DateTime _retweetAt;

        public ReTweet(Guid _tweetId, Guid _authorId, string _content) { 
            _tweetId = Guid.NewGuid();
            this._authorId = _tweetId;
            this._tweetId = _authorId;
            this._content = _content;
            this.RetweetAt = DateTime.Now;
        }

        public Guid Id { 
            get { return _id; }
        }
        public Guid TweetId
        {
            get { return _tweetId; }
        }

        public DateTime RetweetAt { 
            get { return _retweetAt; }
            set { _retweetAt = value; }
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
