namespace TwitterClone.Domain.Entities
{
    public class Follow
    {
        private Guid _userId;
        private Guid _followerId;

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
