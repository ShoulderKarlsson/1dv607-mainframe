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
        //private readonly model.Database _DAL;
        private readonly model.MemberOperations _memberoOps;
        private readonly view.DeleteView _dView;


        public DeleteController()
        {
            model.Database _DAL = new Database();
            model.MemberCatalog _memCat = new MemberCatalog(_DAL);
            _memberoOps = new model.MemberOperations(_memCat, _DAL);
            _dView = new DeleteView(_memberoOps);
        }

        public void CollectInformation()
        {
            _dView.Render();
            string personalNumber = _dView.GetUserPersonalNumber();
            _memberoOps.RemoveUser(personalNumber);
        }
    }
}
