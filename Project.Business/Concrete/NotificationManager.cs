using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Business.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDal _notDal;

        public NotificationManager(INotificationDal notDal)
        {
            _notDal = notDal;
        }

        public void Add(Notification notification)
        {
            _notDal.Add(notification);
        }

        public List<Notification> GetAll()
        {
            return _notDal.GetList();
        }

        public void Update(Notification notification)
        {
            _notDal.Update(notification);
        }
    }
}
