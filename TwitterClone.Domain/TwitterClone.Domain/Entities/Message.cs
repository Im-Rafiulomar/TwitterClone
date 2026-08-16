namespace TwitterClone.Domain.Entities
{
    public class Message
    {
        private Guid _messageId;
        private string _messageText;
        private DateTime _messageTime;
        public Message() { 
            _messageId = Guid.NewGuid();
        }
        public Guid MessageId
        {
            get { return _messageId; }
        }

        public string MessageText {
            get { return _messageText; }
            set { _messageText = value; }
        }

        public DateTime MessageTime { 
            get { return _messageTime; }
            set { _messageTime = value; }
        }
    }
}
