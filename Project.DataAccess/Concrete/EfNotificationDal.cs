﻿using Project.Core.DataAccess.EntityFramework;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.DataAccess.Concrete
{
    public class EfNotificationDal : EfEntityRepositoryBase<Notification, ProjectContext>, INotificationDal
    {
    }
}
