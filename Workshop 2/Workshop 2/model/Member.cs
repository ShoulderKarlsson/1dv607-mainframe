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

        public Member(string name, string personalNumber, int id)
        {
            Name = name;
            PersonalNumber = personalNumber;
            Id = id;
        }


        public string Name { get; set; }

        public string PersonalNumber { get; set; }

        public int Id { get; set; }

        public List<Boat> MemberBoats { get; } = new List<Boat>();

        public void AddBoat(Boat boat)
        {
            MemberBoats.Add(boat);
        }

        public string VerboseToString()
        {
            string boats = CollectBoats();
            return $"\nID: {Id} \nName: {Name} \nPersonal Number: {PersonalNumber} \nBoats: {boats}";
        }

        public string CompactToString()
        {
            return $"\nID: {Id} \nName: {Name} \nNumber of boats: {MemberBoats.Count}";
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