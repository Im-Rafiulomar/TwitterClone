namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _id; // // Class unique id
        private Guid _userId;
        private Guid _followerId;
        private DateTime _followAt;
        public Follow(Guid _userId, Guid _followerId) {
            _id = Guid.NewGuid();
            this._userId = _userId;
            this._followerId = _followerId;
            this._followAt = DateTime.Now;
        }

        public Guid Id
        {
            get { return _id; }
        }

        public DateTime FollowAt {
            get { return _followAt; }
            set { _followAt = value; }
        }

        public Guid UserId
        {
            get { return _userId; }
        }

        public Guid FollowerId
        {
            get { return _followerId; }
        }
    }
}
