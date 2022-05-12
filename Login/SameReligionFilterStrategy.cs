using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class SameReligionFilterStrategy : IFilterStrategy
    {
        bool IFilterStrategy.DoFilterOnFriends(Request i_Request)
        {
            return i_Request.Friend.Religion == i_Request.MainUser.Religion;
        }
    }
}
