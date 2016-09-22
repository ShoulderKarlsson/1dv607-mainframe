using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;

namespace Workshop_2.model
{
    class Database
    {
        private string filePath = @"..\..\db\members.json";
        private List<Member> _storedMembers;


        public Database()
        {
            _storedMembers = GetMembers();
        }

        public bool IsPersonalNumberTaken(string personalNumber)
        {
            bool found = false;
            if (_storedMembers == null)
            {
                _storedMembers = new List<Member>();
            }


            foreach (Member memberInfo in _storedMembers)
            {
                if (memberInfo.PersonalNumber == personalNumber)
                {
                    found = true;
                }
            }

            return found;
        }

        public void AddUser(Member newMember)
        {
            
            _storedMembers.Add(newMember);
            UpdateDatabase();
        }

        private void UpdateDatabase()
        {
            string json = JsonConvert.SerializeObject(_storedMembers, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        public void RemoveUser(string personalNumber)
        {
            for (int mIx = 0; mIx < _storedMembers.Count; mIx++)
            {
                if (_storedMembers[mIx].PersonalNumber == personalNumber)
                {
                    _storedMembers.Remove(_storedMembers[mIx]);
                }
            }

            UpdateDatabase();
        }

        public void UpdateUser()
        {
            
        }

        private List<model.Member> GetMembers()
        {
            string json;
            using (StreamReader r = new StreamReader(filePath))
            {
                json = r.ReadToEnd();
            }
            return JsonConvert.DeserializeObject<List<model.Member>>(json);
        }
    }
}
