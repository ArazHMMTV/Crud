﻿using MultiShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Data.RepositoryAbstract
{
    public interface IGenericRepository<T> where T:BaseEntity,new()
    {
        void Add(T entity);
        void Delete (T entity);
        T Get(Func<T, bool>? func=null);
        List<T> GetAll(Func<T,bool>? func=null);
        int Commit();
        Task<int> CommitAsync();
    }
}
