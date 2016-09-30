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
            
            string username = _rView.GetUsername();
            string personalNumber = _rView.GetUserPersonalNumber();
            int memberId = _memberOps.GenerateID();

            model.Member newMember = new model.Member(username, personalNumber, memberId);
            SaveMember(newMember);
        }

        private void SaveMember(Member member)
        {
            _memberOps.AddUser(member);
        }


    }
}
