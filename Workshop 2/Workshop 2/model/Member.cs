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


        public string Name { get; set; }

        public string PersonalNumber { get; }

        public List<Boat> MemberBoats { get; } = new List<Boat>();

        public void AddBoat(Boat boat)
        {
            MemberBoats.Add(boat);
        }

        public override string ToString()
        {
            string boats = CollectBoats();
            return $"Name: {Name} \n Personal Number: {PersonalNumber} \n {boats}";
        }

        private string CollectBoats()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Boat boat in MemberBoats)
            {
                sb.Append(boat);
            }

            return sb.ToString();
        }
    }
}