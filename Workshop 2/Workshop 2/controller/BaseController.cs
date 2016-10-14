using Workshop_2.model;

namespace Workshop_2.controller
{
    abstract class BaseController
    {
        protected Database _DAL;
        protected MemberCatalog _memberCatalog;
        protected MemberOperations _memberOperations;

        public BaseController()
        {
            _DAL = new Database();
            _memberCatalog = new MemberCatalog(_DAL);
            _memberOperations = new MemberOperations(_memberCatalog, _DAL);
        }
    } 
}
