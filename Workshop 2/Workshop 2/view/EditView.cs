using System;
using Workshop_2.model;

namespace Workshop_2.view
{
    class EditView : BaseView
    {
        public EditView(MemberOperations mOps) : base(mOps) { }

        public void Render()
        {
            ClearConsole();
            Console.WriteLine("Enter personal number for the person to edit: ");
        }

        public string GetUserChoice()
        {
            Console.WriteLine("What would like to update? \n " +
                              "1. Name \n " +
                              "2. Personal Number \n " +
                              "3. Boat Information");

            return DropDownUserChoiceValidation(3);
        }

        private string DropDownUserChoiceValidation(int arg)
        {
            bool shouldLoop = true;
            string choice = "";
            do
            {

                try
                {
                    choice = Console.ReadLine();
                    int value;
                    bool isNumeric = int.TryParse(choice, out value);
                    if (!isNumeric || value > arg || value < 0)
                    {
                        throw new Exception("Invalid choice.");
                    }

                    shouldLoop = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (shouldLoop);

            return choice;
        }

        public string EditName()
        {
            Console.Write("New name:");
            return Console.ReadLine();
        }

        public int ChooseBoat(int amountOfBoats)
        {
            Console.Write("Select boat ID:");

            // Will always be int, validting in input method.
            return int.Parse(DropDownUserChoiceValidation(amountOfBoats));
        }

        public int BoatEditOption()
        {
            Console.WriteLine("Select option:");
            Console.WriteLine("1. Type");
            Console.WriteLine("2. Length");

            // Will always be int, validating in input method.
            return int.Parse(DropDownUserChoiceValidation(2));
        }

        public void PresentBoats(Member member)
        {
            Console.WriteLine("Select ID of boat to edit");
            foreach (Boat boat in member.MemberBoats)
            {
                Console.WriteLine($"ID: {boat.ID}: {boat}");
            }
        }

        public void PresentMemberInfo(Member memberInfo) => Console.WriteLine(memberInfo.ToString());
    }
}
