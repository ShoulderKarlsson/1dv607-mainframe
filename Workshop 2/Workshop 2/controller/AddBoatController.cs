using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;
using Workshop_2.view;

namespace Workshop_2.controller
{
    class AddBoatController : BaseController
    {
        private readonly view.AddBoatView _abView;

        public AddBoatController()
        {
            _abView = new AddBoatView(_memberOperations);
        }
        public void CollectInformation()
        {
            string personalNumber = _abView.GetUserPersonalNumber();
            BoatLength bl = _abView.GetBoatLength();
            string bt = _abView.GetBoatType();

            // Will always be int, validating when setting value.
            Boat newBoat = new Boat(bt, int.Parse(bl.Length));
            _memberOperations.SaveBoat(newBoat, personalNumber);
        }

    }
}