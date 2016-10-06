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
        private string filePath = @"db\members.json";
        private List<Member> _storedMembers;


        public Database()
        {
            _storedMembers = GetMembers();
        }

        public void UpdateDatabase(List<Member> mList)
        {
            string json = JsonConvert.SerializeObject(mList, Formatting.Indented);
            File.WriteAllText(filePath, json);
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

        public List<Member> GetMemberList()
        {
            return _storedMembers;
        }
    }
}
