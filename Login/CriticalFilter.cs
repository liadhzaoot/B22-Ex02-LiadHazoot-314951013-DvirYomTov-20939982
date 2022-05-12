using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    /// <summary>
    /// Part of Chain of Responsability pattern.
    /// ConcreteHandler 2
    /// </summary>
    public class CriticalFilter : FriendFilter
    {

        public CriticalFilter(IFilterStrategy i_FilterTest) : base(i_FilterTest)
        {
        }
        protected override void handleRequestOrMoveToNext(Request io_Request, bool i_FriendPassedTheFilterTest)
        {
            if (i_FriendPassedTheFilterTest)
            {
                if (NextHandler != null)
                {
                    NextHandler.Proccess(io_Request);
                }
                else
                {
                    handle(io_Request);
                }
            }
        }
    }
}
