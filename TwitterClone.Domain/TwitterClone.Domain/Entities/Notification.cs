namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _notificationId;
        private string _notificationContent;
        public Notification() { 
            _notificationId = Guid.NewGuid();
        }
        public Guid NotificationId{
            get { return _notificationId; }
        }

        public string NotificationContent
        {
            get { return _notificationContent; }
            set { _notificationContent = value; }
        }
    }
}
