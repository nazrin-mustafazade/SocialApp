﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.DataAccess;
using Project.Entities.Concrete;

namespace Project.DataAccess.Abstract
{
    public interface IPostDal: IEntityRepository<Post>
    {
    }
}
