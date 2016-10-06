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

        internal MemberOperations MemberOperations
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        internal BoatLength BoatLength
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

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

        public string GetBoatType()
        {

            for (int i = 0; i < Enum.GetNames(typeof (Sal)).Length; i++)
            {
                Console.WriteLine($"{i}: {Sal.GetName(typeof(Sal), i)}");      
            }

            do
            {
                Console.Write("Choose boat type: ");
                try
                {
                    int choice;
                    string value = Console.ReadLine();
                    if (int.TryParse(value, out choice))
                    {
                        if (choice > Enum.GetNames(typeof (Sal)).Length - 1 || choice < 0)
                        {
                            throw new Exception("That is not a valid choice");
                        }
                    }

                    return Sal.GetName(typeof (Sal), choice);
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (true);
        }
    }
}
