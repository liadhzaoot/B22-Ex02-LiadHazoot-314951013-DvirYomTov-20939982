﻿using FacebookWrapper.ObjectModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    /// <summary>
    /// This class implentes the Iterator pattern.
    /// We get next matched friend after all actions of filtering.
    /// 
    /// This class is our Client in the Chain Of Resposability pattern.
    /// </summary>
    public class FriendsToMatch : IEnumerable<User>
    {
        private readonly IEnumerable<User> r_Friends;
        private readonly User r_User;
        private readonly FriendFilter r_ChainOfHandlersEntry;
        private int r_Score;

        public FriendsToMatch(User i_User, IEnumerable<User> i_Friends, LinkedList<ChainOfHandlers.eFilters> i_ListOfOptionalFilters, int i_Score)
        {
            r_User = i_User;
            r_Friends = i_Friends;
            r_ChainOfHandlersEntry = ChainOfHandlers.Build(i_ListOfOptionalFilters);
            r_Score = Math.Min(i_Score, i_ListOfOptionalFilters.Count);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<User> GetEnumerator()
        {
            foreach (User friend in r_Friends)
            {
                Request request = new Request(r_User, friend, r_Score);
                r_ChainOfHandlersEntry.Proccess(request);
                if (request.IsFriendMatchable)
                {
                    yield return friend;
                }
            }
        }
    }
}
