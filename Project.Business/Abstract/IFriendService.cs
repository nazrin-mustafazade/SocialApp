using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.DataAccess.Abstract;

namespace Project.Business.Abstract
{
    public interface IFriendService
    {

        List<Friend> GetFriends(int Id);
        void AddFriend(Friend UserId);
        void RemoveFriend(Friend UserId);
    }
}
