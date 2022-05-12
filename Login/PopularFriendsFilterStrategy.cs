using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class PopularFriendsFilterStrategy : IFilterStrategy
    {
        private const int k_NumberOfFriendsThatMakeSomeonePopular = 100;

        bool IFilterStrategy.DoFilterOnFriends(Request i_Request)
        {
            return i_Request.Friend.Friends.Count >= k_NumberOfFriendsThatMakeSomeonePopular;
        }
    }
}
