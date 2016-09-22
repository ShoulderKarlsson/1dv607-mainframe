using System;

namespace Workshop_2.model
{
    public class Boat
    {
        private string _type;
        private int _length;

        public Boat(string type, int length)
        {
            Type = type;
            Length = length;
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