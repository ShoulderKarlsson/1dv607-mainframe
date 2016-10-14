﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using Workshop_2.model;

namespace Workshop_2.view
{
    class ListView : BaseView
    {

        public ListView(MemberOperations mOps) : base(mOps) { }

        public string GetListChoice()
        {
            ClearConsole();
            string choice = "";
            bool shouldLoop = true;
            Console.WriteLine("What type of list? \n " +
                              "1. Compact \n " +
                              "2. Verbose \n " +
                              "3. Single Member");
            do
            {
                Console.Write(": ");
                try
                {
                    choice = Console.ReadLine();

                    int number;
                    bool isNumeric = int.TryParse(choice, out number);

                    if (!isNumeric || number > 3 || number <= 0)
                    {
                        throw new Exception("Invalid Choice.");
                    }
                    shouldLoop = false;
                }
                catch (Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            } while (shouldLoop);

            return choice;
        }

        public void DisplayCompact(List<model.Member> users)
        {
            foreach (model.Member user in users)
            {
                Console.WriteLine(user.CompactToString());
            }
        }

        public void DisplayVerbose(List<model.Member> users)
        {
            foreach (model.Member user in users)
            {
                Console.WriteLine(user.VerboseToString());
            }
        }

        public void DisplaySingleMember(Member member)
        {
            Console.WriteLine(member);
        }
    }
}
