using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;
using Workshop_2.view;


namespace Workshop_2.controller
{
    class RegisterController
    {
        private readonly model.MemberOperations _memberOps;
        private readonly model.MemberCatalog _memberCat;
        private readonly view.RegisterView _rView;

        public RegisterController()
        {
            Database db = new Database();
            _memberCat = new MemberCatalog(db);
            _memberOps = new MemberOperations(_memberCat, db);
            _rView = new RegisterView(_memberOps);
        }
        
        public void CollectInformation()
        {
            _rView.Render();

            //MemberPersonalNumber personalNumber = GetPersonalNumber();




            MemberName mN = _rView.GetName();
            string personalNumber = _rView.GetUserPersonalNumber();
            int memberId = _memberOps.GenerateID();
            model.Member newMember = new model.Member(mN.Name, personalNumber, memberId);
            //model.Member newMember = new model.Member(mN.Name, personalNumber.PersonalNumber, memberId);
            SaveMember(newMember);
        }

        private void SaveMember(Member member)
        {
            _memberOps.AddUser(member);
        }

        /*private MemberPersonalNumber GetPersonalNumber()
        {
            MemberPersonalNumber personalNumber = _rView.GetPersonalNumber();

            if (_rView.CheckAlreadyExists(personalNumber.PersonalNumber))
            {
                GetPersonalNumber();
            }

            return personalNumber;
        }*/
    }
}
