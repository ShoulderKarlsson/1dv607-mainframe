using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Workshop_2.model
{
    public class Member
    {
        private string _name;
        private string _personalNumber;
        private int _id;
        private int _fee = 0;
        private List<Boat> _memberBoats = new List<Boat>();

        public Member(string name, string personalNumber)
        {
            Name = name;
            PersonalNumber = personalNumber;
        }


        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public string PersonalNumber
        {
            get { return _personalNumber; }
            private set
            {
                _personalNumber = value;
            }
        }

        public List<Boat> MemberBoats
        {
            get { return new List<Boat>(_memberBoats);}
        }

        public void AddBoat(Boat boat)
        {
            _memberBoats.Add(boat);
        }

        public override string ToString()
        {
            return string.Format("Name: {0} - PersonalNumber : {1} - Fee: {2}", Name, PersonalNumber, _fee);
        }
    }
}