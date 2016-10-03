using System;
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
        public AddBoatView(model.MemberOperations mOps) : base(mOps)
        {
            
        }

        protected override void CheckAlreadyExists(string personalNumber)
        {
            if (!_memberOps.IsPersonalNumberTaken(personalNumber))
            {
                throw new Exception("That user does not exist.");
            }
        }

        public model.Boat GetNewBoatDetails()
        {

            string boatType = GetBoatType();
            int boatLength = GetBoatLength();

            return new Boat(boatType, boatLength);

        }

        private int GetBoatLength()
        {
            Console.Write("Boat length: ");
            return int.Parse(Console.ReadLine());
        }

        private string GetBoatType()
        {
            Console.Write("Boat type: ");
            return Console.ReadLine();
        }
    }
}
