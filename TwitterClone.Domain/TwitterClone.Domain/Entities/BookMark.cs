namespace TwitterClone.Domain.Entities
{
    public class BookMark
    {
        private Guid _id; // Class unique id
        private Guid _tweetId;
        private string _bookmarkContent;
        private DateTime _bookmarkAt;

        public BookMark(Guid _tweetId, string _bookmarkContent) { 
            _id = Guid.NewGuid();
            this._tweetId = _tweetId;
            this._bookmarkContent = _bookmarkContent;
            this._bookmarkAt = DateTime.Now;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public DateTime BookmarkAt
        {
            get { return _bookmarkAt; }
            set { _bookmarkAt = value; }
        }

        public Guid TweetId { 
            get { return _tweetId; }
        }

        public string BookmarkContent {
            get { return _bookmarkContent; }
            set { _bookmarkContent = value; }
        }
    }
}
