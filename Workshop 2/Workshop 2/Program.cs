using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace Workshop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "..\\..\\db\\members.json";

            string json;
            using (StreamReader r = new StreamReader(filePath))
            {
                json = r.ReadToEnd();

            }

            List<model.User> numbers = JsonConvert.DeserializeObject<List<model.User>>(json);
            foreach (var user in numbers)
            {
                Console.WriteLine(user.username);
                Console.WriteLine(user.personal_id);
            }

        }
    }
}
