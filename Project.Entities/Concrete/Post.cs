using Project.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities.Concrete
{
    public class Post:IEntity
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public int Category_Id { get; set; }
        public int Like_Count { get; set; }
        public int Comment_Count { get; set; }
        public string Post_Content { get; set; }
        public string Path { get; set; }
    }
}
