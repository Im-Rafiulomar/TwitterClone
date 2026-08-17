namespace TwitterClone.Domain.Entities {
    public class Tweet {
        private Guid _id; // Class unique id
        private Guid _authorId;
        private string _content;
        private DateTime _tweetAt;

        public Tweet(Guid _authorId, string _content) { 
            _id = Guid.NewGuid();
            this._authorId = _authorId;
            this._content = _content;
            this._tweetAt = DateTime.Now;
        }
        public Guid Id {
            get { return _id; }
        }
        public DateTime TweetAt
        {
            get { return _tweetAt; }
        }
        public Guid AuthorId { 
            get { return _authorId; }
        }
        public string Content {
            get { return _content; }
            set { _content = value; }
        }

    }
}
