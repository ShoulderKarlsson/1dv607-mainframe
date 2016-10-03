using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;
using Workshop_2.view;

namespace Workshop_2.controller
{
    class AddBoatController
    {

        private readonly model.MemberOperations _memberOps;
        private readonly model.MemberCatalog _memberCat;
        private readonly view.AddBoatView _abView;

        /// <summary>
        /// 1. Get personal number (Got it)
        /// 2. Input type of boat (GOT it)
        /// 3. Input length of boat (GOT it)
        /// 3. (WE) add ID to boat.
        /// </summary>

        public AddBoatController()
        {
            model.Database db = new Database();
            _memberCat = new MemberCatalog(db);
            _memberOps = new MemberOperations(_memberCat, db);
            _abView = new AddBoatView(_memberOps);
        }
        public void CollectInformation()
        {
            string personalNumber = _abView.GetUserPersonalNumber();
            model.Boat newBoat = _abView.GetNewBoatDetails();
            _memberOps.SaveBoat(newBoat, personalNumber);
        }
    }
}
