using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Abstract
{
    public interface INotificationService
    {
        List<Notification> GetAll();
        void Update(Notification notification);
        void Add(Notification notification);
    }
}
