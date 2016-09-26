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
        public DeleteView(Database DAL) : base(DAL) { }

        public void Render()
        {
            Console.WriteLine("Input personal number.");
        }

        protected override void CheckAlreadyExists(string personalNumber)
        {
            if (!_DAL.IsPersonalNumberTaken(personalNumber))
            {
                throw new Exception("That user does not exist.");
            }
        }
    }
}
