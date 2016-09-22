using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Workshop_2.model;


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

            //#region writeToFile
            //string filePath = "..\\..\\db\\members.json";

            //model.Member m1 = new model.Member("Loke", "45");
            //m1.AddBoat(new model.Boat("Canoe", 5));
            //m1.AddBoat(new model.Boat("Färja", 3));
            //List<model.Member> memberlist = new List<model.Member>();
            //memberlist.Add(m1);






            //string json = JsonConvert.SerializeObject(memberlist, Formatting.Indented);
            //File.WriteAllText(filePath, json);
            //#endregion

            /*
             * Göra något som hanterar databasen.
             * Spara ner medlemmar till den requiremetns.
             * Gå vidare med requiremetnstn
             */

            controller.BaseController bc = new controller.BaseController();
            bc.Init();

            //model.Database dal = new Database();
            //var hej = dal.GetMembers();
        }
    }
}
