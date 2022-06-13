using System.Collections.Generic;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDAL commentDAL;
        public CommentManager(ICommentDAL _commentDAL)
        {
            commentDAL=_commentDAL;
        }

        public List<Comment> GetList(int id)
        {
            return commentDAL.GetListAll(x=>x.BlogId == id );
        }
        public void TAdd(Comment t)
        {
            commentDAL.Insert(t);
        }

        public void TDelete(Comment t)
        {
            throw new System.NotImplementedException();
        }

        public Comment TGetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public List<Comment> TGetList()
        {
            throw new System.NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new System.NotImplementedException();
        }
    }
}