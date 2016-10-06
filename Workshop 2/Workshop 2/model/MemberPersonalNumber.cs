//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Workshop_2.model
//{
//    class MemberPersonalNumber
//    {
//        private string _personalNumber;
//        public MemberPersonalNumber(string personalNumber)
//        {
//            PersonalNumber = personalNumber;
//        }

//        public string PersonalNumber
//        {
//            get { return _personalNumber; }
//            set
//            {
//                if (value.Any(c => !char.IsDigit(c)))
//                {
//                    throw new Exception("Personal number can only contain numbers!");
//                }

//                if (value.Length != 10)
//                {
//                    throw new Exception("Personal Number must be 10 numbers long.");
//                }

//                _personalNumber = value;
//            }
//        }
//    }
//}
