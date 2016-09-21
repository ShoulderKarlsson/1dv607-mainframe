using System.Collections.Generic;

namespace Workshop_2.model
{
    public class Member
    {
        public string _name;
        //private int _personalNumber;
        public int _id;
        public List<Boat> _memberBoats;
        //private Calendar _calendar;
        //private int _fee;


        public Member(string name, int id, List<Boat> boats)
        {
            _name = name;
            _id = id;
            _memberBoats = boats;
        }




    }
}