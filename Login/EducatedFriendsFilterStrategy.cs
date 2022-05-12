using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class EducatedFriendsFilterStrategy : IFilterStrategy
    {
        bool IFilterStrategy.DoFilterOnFriends(Request i_Request)
        {
            return i_Request.Friend.Educations.Length != 0;
        }
    }
}
