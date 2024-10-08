﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookWeb.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T:class
    {
        //T- is any model 
        IEnumerable<T> GetAll(Expression<Func<T,bool>>? filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Remove(T enttiy);
        void RemoveRange(IEnumerable<T> entity);
    }
}
