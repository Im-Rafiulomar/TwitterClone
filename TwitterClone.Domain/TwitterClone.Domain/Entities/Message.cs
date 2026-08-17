namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _id; // Class unique id
        private string _messageText;
        private DateTime _messageAt;
        public Message(string _messageText) { 
            _id = Guid.NewGuid();
            this._messageText = _messageText;
            this._messageAt = DateTime.Now;
        }
        public Guid Id
        {
            get { return _id; }
        }

        public string MessageText {
            get { return _messageText; }
            set { _messageText = value; }
        }

        public DateTime MessageAt { 
            get { return _messageAt; }
            set { _messageAt = value; }
        }
    }
}
