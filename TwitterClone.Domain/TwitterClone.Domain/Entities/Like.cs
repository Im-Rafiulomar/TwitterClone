namespace TwitterClone.Domain.Entities
{
    public class Like
    {
        private Guid _id; // Class unique id
        private Guid _userId;
        private Guid _tweetId;
        private DateTime _likeAt;
        public Like(Guid _userId, Guid _tweetId) { 
            _id = Guid.NewGuid();
            this._userId = _userId;
            this._tweetId = _tweetId;
            this._likeAt = DateTime.Now;
        }
        public Guid _Id {
            get { return _id; }
        }
        public Guid UserId { 
            get { return _userId; }
        }
        public Guid TweetId {
            get { return _tweetId; }
        }
        public DateTime LikeAt
        {
            get { return _likeAt; }
            set { _likeAt = DateTime.Now; }
        }
    }
}
