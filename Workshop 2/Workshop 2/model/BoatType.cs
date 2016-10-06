//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Workshop_2.model
//{
//    class BoatType
//    {
//        private string _type;

//        public BoatType(string type)
//        {
//            Type = type;
//        }
//        public string Type
//        {
//            get { return _type; }
//            set
//            {
//                if (value.Any(char.IsDigit))
//                {
//                    throw new Exception("No digits allowed.");
//                }

//                _type = value;
//            }
//        }
//    }
//}
