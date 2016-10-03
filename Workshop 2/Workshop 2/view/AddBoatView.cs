using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;

namespace Workshop_2.view
{
    class AddBoatView : BaseView
    {
        public AddBoatView(model.MemberOperations mOps) : base(mOps) { }

        protected override void CheckAlreadyExists(string personalNumber)
        {
            if (!_memberOps.IsPersonalNumberTaken(personalNumber))
            {
                throw new Exception("That user does not exist.");
            }
        }
        public BoatLength GetBoatLength()
        {
            do
            {
                Console.Write("Boat Length: ");

                try
                {
                    return new BoatLength(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (true);
        }

        public BoatType GetBoatType()
        {
            do
            {
                Console.Write("Boat Type: ");

                try
                {
                    return new BoatType(Console.ReadLine());
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (true);
        }
    }
}
