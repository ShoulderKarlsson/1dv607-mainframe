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

        public model.Member GetUserInfo(string personalNumber)
        {
            foreach (model.Member member in _storedMembers)
            {
                if (member.PersonalNumber == personalNumber)
                {
                    return member;
                }
            }

            return null;
        }

        public void UpdateUser(model.Member memberCredentials)
        {
            for (int i = 0; i < _storedMembers.Count; i++)
            {
                if (_storedMembers[i].PersonalNumber == memberCredentials.PersonalNumber)
                {
                    _storedMembers[i] = memberCredentials;
                }
            }

            UpdateDatabase();
        }

        public void UpdateUser(model.Member memberCredentials, string newPn)
        {
            for (int i = 0; i < _storedMembers.Count; i++)
            {
                if (_storedMembers[i].PersonalNumber == memberCredentials.PersonalNumber)
                {
                    memberCredentials.PersonalNumber = newPn;
                    _storedMembers[i] = memberCredentials;
                    break; // Premature optimization is the root of all evil.
                }
            }

            UpdateDatabase();
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


        public int QueryLowestAvailable() => _storedMembers.Count == 0 ? 1 : _storedMembers.OrderBy(m => m.Id).Last().Id + 1;
    }
}
