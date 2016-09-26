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
        private readonly model.Database _DAL;
        private readonly view.RegisterView _rView;

        public RegisterController()
        {
            _DAL = new Database();
            _rView = new RegisterView(_DAL);
        }
        
        public void CollectInformation()
        {
            _rView.Render();
            
            string username = _rView.GetUsername();
            string personalNumber = _rView.GetUserPersonalNumber();
            int memberId = _DAL.QueryLowestAvailable();
            model.Member newMember = new model.Member(username, personalNumber, memberId);
            newMember.AddBoat(new Boat("Kajak", 42));
            newMember.AddBoat(new Boat("Loke", 2));
            SaveMember(newMember);
        }

        private void SaveMember(Member member)
        {
            _DAL.AddUser(member);
        }
    }
}
