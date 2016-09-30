﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Workshop_2.model
{
    class MemberOperations
    {
        private List<Member> _storedMembers;
        private readonly model.Database _DAL;
        public MemberOperations(model.MemberCatalog mCat, Database db)
        {
            _DAL = db;
            _storedMembers = mCat._storedMembers;
        }

        public int GenerateID() => _storedMembers.Count == 0 ? 1 : _storedMembers.OrderBy(m => m.Id).Last().Id + 1;

        public void UpdateUser(model.Member memberCredentials, string newPn)
        {
            for (int i = 0; i < _storedMembers.Count; i++)
            {
                if (_storedMembers[i].PersonalNumber == memberCredentials.PersonalNumber)
                {
                    memberCredentials.PersonalNumber = newPn;
                    _storedMembers[i] = memberCredentials;
                    break; // Premature optimization is the root of all evil.
                }
            }

            _DAL.UpdateDatabase(_storedMembers);
        }

        public void UpdateUser(model.Member memberCredentials)
        {
            for (int i = 0; i < _storedMembers.Count; i++)
            {
                if (_storedMembers[i].PersonalNumber == memberCredentials.PersonalNumber)
                {
                    _storedMembers[i] = memberCredentials;
                }
            }

            _DAL.UpdateDatabase(_storedMembers);
        }

        public model.Member GetUserInfo(string personalNumber)
        {
            foreach (model.Member member in _storedMembers)
            {
                if (member.PersonalNumber == personalNumber)
                {
                    return member;
                }
            }

            return null;
        }

        public void RemoveUser(string personalNumber)
        {
            for (int mIx = 0; mIx < _storedMembers.Count; mIx++)
            {
                if (_storedMembers[mIx].PersonalNumber == personalNumber)
                {
                    _storedMembers.Remove(_storedMembers[mIx]);
                }
            }

            _DAL.UpdateDatabase(_storedMembers);
        }

        public void AddUser(Member newMember)
        {

            _storedMembers.Add(newMember);
            _DAL.UpdateDatabase(_storedMembers);
        }

        public bool IsPersonalNumberTaken(string personalNumber)
        {
            bool found = false;
            if (_storedMembers == null)
            {
                _storedMembers = new List<Member>();
            }


            foreach (Member memberInfo in _storedMembers)
            {
                if (memberInfo.PersonalNumber == personalNumber)
                {
                    found = true;
                }
            }

            return found;
        }


    }
}