using ApiAcoes.Context;
using ApiAcoes.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ApiAcoes.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public virtual T GetOne(Func<T, bool> where)
        {
            using (var context = new BtgDbContext())
            {
                return context
                    .Set<T>()
                    .AsNoTracking()
                    .FirstOrDefault(where);
            }
        }

        public virtual bool Exists(Func<T, bool> where)
        {
            using (var context = new BtgDbContext())
            {
                return context
                    .Set<T>()
                    .Any(where);
            }
        }

        public virtual IList<T> GetAll()
        {
            using (var context = new BtgDbContext())
            {
                return context
                    .Set<T>()
                    .AsNoTracking()
                    .ToList();
            }
        }

        public virtual IList<T> Get(Func<T, bool> where)
        {
            using (var context = new BtgDbContext())
            {
                return context
                    .Set<T>()
                    .AsNoTracking()
                    .Where(where)
                    .ToList();
            }
        }

        public virtual bool TryAdd(params T[] items)
        {
            using (var context = new BtgDbContext())
            {
                foreach (var item in items)
                {
                    context.Entry(item).State = EntityState.Added;
                }
                context.SaveChanges();
                return true;
            }
        }

        public virtual bool TryUpdate(params T[] items)
        {
            using (var context = new BtgDbContext())
            {
                try
                {
                    foreach (var item in items)
                    {
                        context.Entry(item).State = EntityState.Modified;
                    }
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public virtual bool TryDelete(params T[] items)
        {
            using (var context = new BtgDbContext())
            {
                try
                {
                    foreach (var item in items)
                    {
                        context.Entry(item).State = EntityState.Deleted;
                    }
                    context.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}

