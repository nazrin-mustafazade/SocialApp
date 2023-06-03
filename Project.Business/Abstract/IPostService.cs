using Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Business.Abstract
{
    public interface IPostService
    {
        List<Post> GetAll();
        List<Post> GetByCategory(int categoryId);
        List<Post> GetByUser(int userId);
        void Add(Post post);
        void Update(Post post);
        void Delete(Post post);
        Post GetById(int id);
    }
}
