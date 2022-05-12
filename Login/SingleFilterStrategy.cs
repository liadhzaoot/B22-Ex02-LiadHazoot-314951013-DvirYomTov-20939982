using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class SingleFilterStrategy : IFilterStrategy
    {
        bool IFilterStrategy.DoFilterOnFriends(Request i_Request)
        {
            return i_Request.Friend.RelationshipStatus == User.eRelationshipStatus.Divorced ||
                i_Request.Friend.RelationshipStatus == User.eRelationshipStatus.Single ||
                i_Request.Friend.RelationshipStatus == User.eRelationshipStatus.Separated ||
                i_Request.Friend.RelationshipStatus == User.eRelationshipStatus.InAnOpenRelationship;
        }
    }
}
