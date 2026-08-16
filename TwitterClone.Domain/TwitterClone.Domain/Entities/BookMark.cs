namespace TwitterClone.Domain.Entities
{
    public class BookMark
    {
        private Guid _bookmarkId;
        private Guid _tweetId;
        private string _bookmarkContent;

        public BookMark() { 
            _bookmarkId = Guid.NewGuid();
        }

        public Guid BookId
        {
            get { return _bookmarkId; }
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
