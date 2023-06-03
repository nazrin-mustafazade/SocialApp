using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Business.Abstract;
using Project.Entities.Concrete;
using WebApplication.DataAccess.Abstract;

namespace Project.Business.Concrete
{
    public class FriendManager : IFriendService
    {
        IFriendDal _fr;

        public FriendManager(IFriendDal fr)
        {
            _fr = fr;
        }

        public void AddFriend(Friend UserId)
        {
            _fr.Add(UserId);
        }

        public List<Friend> GetFriends(int Id)
        {
            return _fr.GetList(p => p.User_Id == Id || p.User_Friend_Id == Id);
        }

        public void RemoveFriend(Friend UserId)
        {
            throw new NotImplementedException();
        }
    }
}
