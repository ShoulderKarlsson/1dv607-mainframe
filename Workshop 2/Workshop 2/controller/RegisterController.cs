using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Workshop_2.controller
{
    class RegisterController
    {
        private view.RegisterView rView = new view.RegisterView();
        
        public void CollectInformation()
        {
            rView.renderRegisterView();
            
            string username = rView.GetUsername();
            string personalNumber = rView.GetUserPersonalNumber();

            model.Member nMember = new model.Member(username, personalNumber);
            Console.WriteLine(nMember.ToString());
        }
    }
}
