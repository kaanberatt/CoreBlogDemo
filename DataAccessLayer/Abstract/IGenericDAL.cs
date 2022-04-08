using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.Abstract
{
    //Aynı işlemleri yapan diğer interfacelerde implement edilmek üzere genel,generic bir interface oluşturduk
    //Örneğin; IBlogDAL ve ICategoryDAL aynı işlemleri gerçekleştiriyor.
    public interface IGenericDAL<T> where T : class
    {
        void Insert(T t);        
        void Delete(T t);        
        void Update(T t);        
        List<T> GetListAll();
        T GetById(int id);
        
        List<T> GetListAll(Expression<Func<T,bool>> filter);
        
    }
}