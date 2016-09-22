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
        private readonly model.Database _DAL;
        private readonly view.DeleteView _dView;


        public DeleteController()
        {
            _DAL = new Database();
            _dView = new DeleteView(_DAL);
        }

        public void CollectInformation()
        {
            _dView.Render();
            string personalNumber = _dView.GetUserPersonalNumber();
            _DAL.RemoveUser(personalNumber);
        }
    }
}
