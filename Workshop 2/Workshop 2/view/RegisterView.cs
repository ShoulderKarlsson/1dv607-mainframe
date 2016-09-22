using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.controller;
using Workshop_2.model;

namespace Workshop_2.view
{
    class RegisterView : BaseView
    {

        //private model.Database _DAL;
        public RegisterView(model.Database DAL) : base(DAL) {}

        public void RenderRegisterView()
        {
            Console.WriteLine("Enter information about new user.. =)");
        }

        public string GetUsername()
        {   

            string name = "";
            bool shouldLoop = true;

            do
            {
                Console.Write("Name: ");
                try
                {
                    name = Console.ReadLine();
                    if (name.Length < 2)
                    {
                        throw new Exception("Name is to short!");
                    }
                    shouldLoop = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (shouldLoop);

            return name;
        }
    }
}
