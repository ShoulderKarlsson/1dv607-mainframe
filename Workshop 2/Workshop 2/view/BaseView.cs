//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Workshop_2.view
//{
//    abstract class BaseView
//    {

//        protected model.Database _DAL;

//        public BaseView(model.Database DAL)
//        {
//            _DAL = DAL;
//        }
//        virtual public string GetUserPersonalNumber()
//        {
//            string personalNumber = "";
//            bool shouldLoop = true;

//            do
//            {
//                Console.Write("Personal Number: ");
//                try
//                {
//                    personalNumber = Console.ReadLine();

//                    foreach (char letter in personalNumber)
//                    {
//                        if (!char.IsDigit(letter))
//                        {
//                            throw new Exception("Can only be numbers in personal number.");
//                        }
//                    }


//                    if (personalNumber.Length < 10)
//                    {
//                        throw new Exception("Personal Number must be 10 numbers long.");
//                    }

//                    if (_DAL.IsPersonalNumberTaken(personalNumber))
//                    {
//                        throw new Exception("That personal number is already registered, try again.");
//                    }
//                    shouldLoop = false;
//                }
//                catch (Exception error)
//                {
//                    Console.WriteLine(error.Message);
//                }
//            } while (shouldLoop);
//            return personalNumber;
//        }
//    }
//}
