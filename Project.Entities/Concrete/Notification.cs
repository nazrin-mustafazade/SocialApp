using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Entities.Concrete
{
    public class Notification:IEntity
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int User_Sended_Id { get; set; }
        public bool Is_Read { get; set; }
        public bool Is_Accepted { get; set; }
    }
}
