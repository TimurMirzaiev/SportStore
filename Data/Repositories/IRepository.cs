﻿using System;
using System.Collections.Generic;

namespace Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Create(TEntity item);
        TEntity FindById(int id);
        IEnumerable<TEntity> Get();
        IEnumerable<TEntity> Get(Func<TEntity, bool> predicate);
        TEntity Remove(TEntity item);
        void Update(TEntity item);
    }
}
