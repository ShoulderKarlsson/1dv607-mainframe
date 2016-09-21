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
            #region readFromFile
            //string filePath = "..\\..\\db\\members.json";
            //string json;
            //using (StreamReader r = new StreamReader(filePath))
            //{
            //    json = r.ReadToEnd();
            //}
            //List<model.User> numbers = JsonConvert.DeserializeObject<List<model.User>>(json);
            //foreach (var user in numbers)
            //{
            //    Console.WriteLine(user.username);
            //    Console.WriteLine(user.personal_id);
            //}
            #endregion

            #region writeToFile
            //string filePath = "..\\..\\db\\members2.json";
            //List<model.Boat> b = new List<model.Boat>();
            //b.Add(new model.Boat("Canoe", 5));
            //b.Add(new model.Boat("Färja", 3));
            //b.Add(new model.Boat("Roddböt", 2));
            //b.Add(new model.Boat("eka", 1));
            //model.Member m1 = new model.Member("Loke", 9, b);
            //List<model.Member> memberlist = new List<model.Member>();
            //memberlist.Add(m1);
            //Console.WriteLine(memberlist);
            //string json = JsonConvert.SerializeObject(memberlist, Formatting.Indented);
            //File.WriteAllText(filePath, json);
            #endregion
            
            /*
             * Göra något som hanterar databasen.
             * Spara ner medlemmar till den requiremetns.
             * Gå vidare med requiremetnstn
             */
            
            controller.BaseController bc = new controller.BaseController();
            bc.Init();
        }
    }
}
