using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;
using Workshop_2.view;

namespace Workshop_2.controller
{
    class EditController
    {
        private readonly model.Database _DAL;
        private readonly view.EditView _eView;

        public EditController()
        {
            _DAL = new model.Database();
            _eView = new view.EditView(_DAL);
        }

        public void CollectInformation()
        {
            _eView.Render();
            string personalNumber = _eView.GetUserPersonalNumber();
            Member memberInfo = _DAL.GetUserInfo(personalNumber);
            _eView.PresentMemberInfo(memberInfo);
            string choice = _eView.GetUserChoice();
            MakeChange(choice, personalNumber);

        }

        private void MakeChange(string choice, string personalNumber)
        {
            switch (choice)
            {
                case "1":
                    _eView.EditName(personalNumber);
                    break;
                case "2":
                    _eView.EditNumber(personalNumber);
                    break;
                case "3":
                    _eView.EditBoat(personalNumber);
                    break;
            }
        }
    }
}
