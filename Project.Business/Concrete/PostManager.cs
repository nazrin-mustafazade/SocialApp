using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Business.Abstract;
using Project.DataAccess.Abstract;
using Project.Entities.Concrete;

namespace Project.Business.Concrete
{
    public class PostManager : IPostService
    {
        private IPostDal _postDal;

        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }

        public void Add(Post post)
        {
            _postDal.Add(post);
        }

        public void Delete(Post post)
        {
            _postDal.Delete(post);
        }

        public List<Post> GetAll()
        {
            return _postDal.GetList();
        }

        public List<Post> GetByCategory(int categoryId)
        {
            return _postDal.GetList(p => p.Category_Id == categoryId);
        }

        public Post GetById(int id)
        {
            return _postDal.Get(p => p.Category_Id == id);
        }

        public List<Post> GetByUser(int userId)
        {
            return _postDal.GetList(p => p.User_Id == userId);
        }

        public void Update(Post post)
        {
            _postDal.Update(post);
        }
    }
}
