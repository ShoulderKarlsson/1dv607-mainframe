namespace Workshop_2.model
{
    public class Boat
    {
        private string _type;
        private int _length;

        public Boat(string type, int length)
        {
            _type = type;
            _length = length;
        }

        public string Type
        {
            get { return _type; }
            private set { _type = value; }
        }

        public int Length
        {
            get { return _length; }
            private set { _length = value; }
        }
    }
}
