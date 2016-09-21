using System.Collections.Generic;

namespace Workshop_2.model
{
    public class Member
    {
        public string _name;
        private int _personalNumber;
        private int _id;
        private List<Boat> _memberBoats = new List<Boat>();
        //private Calendar _calendar;
        private int _fee;

        public Member(string name)
        {
            Name = name;
        }


        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

    }
}