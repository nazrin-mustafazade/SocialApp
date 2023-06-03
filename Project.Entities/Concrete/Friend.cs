using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Concrete
{
    public class Friend:IEntity
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int User_Friend_Id { get; set; }
    }
}
