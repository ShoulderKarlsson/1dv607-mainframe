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
        public RegisterView(model.MemberOperations mOps) : base(mOps) {}
        
        public void Render()
        {
            Console.WriteLine("Add information! ");
        }

        public void RenderBoatOption()
        {
            Console.WriteLine("Enter personal number for desired user to add boat.");
        }

        /*
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
                    ValidateLength(name);
                    shouldLoop = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (shouldLoop);

            return name;
        }
        */

        public MemberName GetName()
        {
            do
            {
                Console.Write("Name: ");
                try
                {
                    return new MemberName(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (true);    
        }
    }
}
