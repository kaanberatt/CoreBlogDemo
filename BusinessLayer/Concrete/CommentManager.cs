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
        public void CommentAdd(Comment comment)
        {
            commentDAL.Insert(comment);
        }

        public List<Comment> GetList(int id)
        {
            return commentDAL.GetListAll(x=>x.BlogId == id );
        }

    }
}