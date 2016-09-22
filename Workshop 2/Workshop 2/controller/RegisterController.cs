using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;
using Workshop_2.view;


namespace Workshop_2.controller
{
    class RegisterController
    {
        private model.Database _DAL;
        private view.RegisterView rView;

        public RegisterController()
        {
            _DAL = new Database();
            rView = new RegisterView(_DAL);
        }
        

        public void CollectInformation()
        {
            rView.RenderRegisterView();
            
            string username = rView.GetUsername();
            string personalNumber = rView.GetUserPersonalNumber();
            model.Member newMember = new model.Member(username, personalNumber);

            SaveMember(newMember);
        }

        private void SaveMember(Member member)
        {
            _DAL.AddUser(member);
        }
    }
}
