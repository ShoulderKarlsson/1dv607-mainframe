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
    class RegisterController : BaseController
    {
        private readonly view.RegisterView _rView;

        public RegisterController()
        {
            _rView = new RegisterView(_memberOperations);
        }

        public void CollectInformation()
        {
            _rView.Render();
            MemberName mN = _rView.GetName();
            string personalNumber = _rView.GetUserPersonalNumber();
            int memberId = _memberOperations.GenerateID();
            model.Member newMember = new model.Member(mN.Name, personalNumber, memberId);
            SaveMember(newMember);
        }

        private void SaveMember(Member member)
        {
            _memberOperations.AddUser(member);
        }
    }
}
