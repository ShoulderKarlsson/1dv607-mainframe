using System;

namespace Workshop_2.view
{
    class RegisterView : BaseView
    {
        public RegisterView(model.MemberOperations mOps) : base(mOps) {}

        public void Render()
        {
            ClearConsole();
            Console.WriteLine("Add information for new member ");
        }

        public void RenderBoatOption()
        {
            Console.WriteLine("Enter personal number for desired user to add boat.");
        }

        public string GetName()
        {
            do
            {
                Console.Write("Name: ");
                try
                {
                    string name = Console.ReadLine();
                    StringInputValidation(name);
                    return name;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (true);
        }
    }
}