namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _userId;
        private Guid _followerId;

        public Follow() {
            _userId = Guid.NewGuid();
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
