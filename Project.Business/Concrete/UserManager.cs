using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class UserManager:IUserService
    {
        IUserDal _UserManager;

        public UserManager(IUserDal userManager)
        {
            _UserManager = userManager;
        }

        public void Add(User user)
        {
            _UserManager.Add(user);
        }

        public List<User> GetAll()
        {
            return _UserManager.GetList();
        }

        public void Update(User user)
        {
            _UserManager.Update(user);
        }
    }
}
