using System;
using System.Collections.Generic;

namespace ApiAcoes.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        T GetOne(Func<T, bool> where);
        IList<T> GetAll();
        IList<T> Get(Func<T, bool> where);
        bool TryAdd(params T[] items);
        bool TryUpdate(params T[] items);
        bool TryDelete(params T[] items);
        bool Exists(Func<T, bool> where);
    }
}
