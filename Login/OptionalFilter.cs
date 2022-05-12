using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class OptionalFilter : FriendFilter
    {
        public OptionalFilter(IFilterStrategy i_FilterTest) : base(i_FilterTest)
        {
        }

        protected override void handleRequestOrMoveToNext(Request io_Request, bool i_FriendPassedTheFilterTest)
        {
            if (i_FriendPassedTheFilterTest)
            {
                io_Request.Score++;
            }

            if (io_Request.Score >= io_Request.NeededScore)
            {
                handle(io_Request);
            }
            else if (NextHandler != null)
            {
                NextHandler.Proccess(io_Request);
            }
        }
    }
}
