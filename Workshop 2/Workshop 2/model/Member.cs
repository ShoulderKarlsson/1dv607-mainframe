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
        private int _id;
        private int _fee = 0;

        public Member(string name, string personalNumber)
        {
            Name = name;
            PersonalNumber = personalNumber;
        }


        public string Name { get; }

        public string PersonalNumber { get; }

        public List<Boat> MemberBoats { get; } = new List<Boat>();

        public void AddBoat(Boat boat)
        {
            MemberBoats.Add(boat);
        }

        public override string ToString()
        {
            return string.Format("Name: {0} - PersonalNumber : {1} - Fee: {2}", Name, PersonalNumber, _fee);
        }
    }
}