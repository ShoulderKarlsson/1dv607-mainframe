using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using Workshop_2.model;


namespace Workshop_2
{
    class Program
    {
        static void Main(string[] args)
        {
            controller.BaseController bc = new controller.BaseController();
            bc.Init();
        }
    }
}
