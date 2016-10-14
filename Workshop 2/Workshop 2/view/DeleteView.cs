using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;

namespace Workshop_2.view
{
    class DeleteView : BaseView
    {
        public DeleteView(MemberOperations mOps) : base(mOps) { }

        public void Render()
        {
            ClearConsole();
            Console.WriteLine("Input personal number: ");
        }

        public void PresentBoats(Member member)
        {
            Console.WriteLine("Select ID of boat to remove");
            foreach (Boat boat in member.MemberBoats)
            {
                Console.WriteLine($"ID: {boat.ID}: {boat}");
            }
        }

        public int GetBoatID()
        {
            do
            {
                try
                {
                    Console.Write("ID: ");
                    string ID = Console.ReadLine();
                    NumberInputValidation(ID);
                    return int.Parse(ID);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }

            } while (true);
        }
    }
}
