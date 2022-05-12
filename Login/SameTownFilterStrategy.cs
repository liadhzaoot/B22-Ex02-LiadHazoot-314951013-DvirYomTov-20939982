using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class SameTownFilterStrategy : IFilterStrategy
    {
        bool IFilterStrategy.DoFilterOnFriends(Request i_Request)
        {
            return i_Request.Friend.Hometown == i_Request.MainUser.Hometown;
        }
    }
}
