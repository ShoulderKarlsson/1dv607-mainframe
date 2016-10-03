using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;
using Workshop_2.view;

namespace Workshop_2.controller
{
    class DeleteController
    {
        private readonly model.MemberOperations _memberOps;
        private readonly view.DeleteView _dView;

        public DeleteController()
        {
            model.Database _DAL = new Database();
            model.MemberCatalog _memCat = new MemberCatalog(_DAL);
            _memberOps = new model.MemberOperations(_memCat, _DAL);
            _dView = new DeleteView(_memberOps);
        }

        public void CollectInformation()
        {
            _dView.Render();

            //string personalNumber = _dView.GetUserPersonalNumber();
            string personalNumber = GetPersonalNumber();
            _memberOps.RemoveUser(personalNumber);
        }

        public void DeleteBoat()
        {
            string personalNumber = GetPersonalNumber();
            model.Member m = _memberOps.GetUserInfo(personalNumber);
            _dView.PresentBoats(m);
            int ID = _dView.GetBoatID();
            _memberOps.RemoveBoat(m, ID);
        }

        private string GetPersonalNumber() => _dView.GetUserPersonalNumber();
    }
}
