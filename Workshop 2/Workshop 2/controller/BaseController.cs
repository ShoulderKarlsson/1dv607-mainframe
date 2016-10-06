using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;

namespace Workshop_2.controller
{
    abstract class BaseController
    {
        protected model.Database _DAL;
        protected model.MemberCatalog _memberCatalog;
        protected model.MemberOperations _memberOperations;

        public BaseController()
        {
            _DAL = new Database();
            _memberCatalog = new MemberCatalog(_DAL);
            _memberOperations = new MemberOperations(_memberCatalog, _DAL);
        }
    } 
}
