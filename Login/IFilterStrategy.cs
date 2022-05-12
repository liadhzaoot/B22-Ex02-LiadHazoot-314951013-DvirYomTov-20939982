using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public interface IFilterStrategy
    {
        bool DoFilterOnFriends(Request i_Request);
    }
}
