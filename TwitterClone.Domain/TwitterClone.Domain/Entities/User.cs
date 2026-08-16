namespace TwitterClone.Domain.Entities {
    public class User {
        private Guid _id; // Class unique id
        private string _username;
        private string _email;
        private DateTime _createdAt;
        private DateTime _modifiedAt;

        public User(string _username, string _email) {
            _id = Guid.NewGuid();
            this._username = _username;
            this._email = _email;
            this._createdAt = DateTime.Now;
        }
        public Guid Id {
            get { return _id;  }
        }
        public DateTime CreatedAt {
            get { return _createdAt; }
        }
        public DateTime ModifiedAt
        {
            get { return _modifiedAt; }
            set { _modifiedAt = value; }
        }
        public string Username {
            get { return _username; }
            set { _username = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
    }
}
