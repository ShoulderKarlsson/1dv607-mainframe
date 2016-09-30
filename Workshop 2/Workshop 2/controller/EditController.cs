using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
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
        private readonly model.MemberOperations _memberOperations;
        private readonly view.EditView _eView;
        private model.Member _memberInfo;

        public EditController()
        {
            _DAL = new model.Database();
            model.MemberCatalog mOps = new MemberCatalog(_DAL);
            _memberOperations = new MemberOperations(mOps, _DAL);
            _eView = new view.EditView(_memberOperations);
        }

        public void CollectInformation()
        {
            _eView.Render();
            string personalNumber = _eView.GetUserPersonalNumber();
            _memberInfo = _memberOperations.GetUserInfo(personalNumber);
            _eView.PresentMemberInfo(_memberInfo);
            string choice = _eView.GetUserChoice();
            MakeChange(choice);
        }

        private void MakeChange(string choice)
        {

            switch (choice)
            {
                case "1":
                    string newName = _eView.EditName();
                    UpdateName(newName);
                    break;
                case "2":
                    string pNumb = _eView.EditNumber();
                    UpdatePersonalNumber(pNumb);
                    break;
                case "3":
                    _eView.EditBoat();
                    break;
            }
        }

        private void UpdatePersonalNumber(string newPn)
        {
            _memberOperations.UpdateUser(_memberInfo, newPn);
        }

        private void UpdateName(string name)
        {
            _memberInfo.Name = name;
            _memberOperations.UpdateUser(_memberInfo);
        }
    }
}
