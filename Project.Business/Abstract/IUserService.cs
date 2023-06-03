using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        List<User> GetAll();
        void Update(User user);
    }
}
