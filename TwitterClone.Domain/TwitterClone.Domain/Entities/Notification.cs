namespace TwitterClone.Domain.Entities
{
    public class Notification
    {
        private Guid _id;
        private string _notificationContent;
        private DateTime _notificationAt;
        public Notification(string _notificationContent) { 
            _id = Guid.NewGuid();
            this._notificationContent = _notificationContent;
            this._notificationAt = DateTime.Now;
        }
        public Guid Id {
            get { return _id; }
        }

        public DateTime NotificationAt {
            get { return _notificationAt; }
            set { _notificationAt = value; }
        }

        public string NotificationContent
        {
            get { return _notificationContent; }
            set { _notificationContent = value; }
        }
    }
}
