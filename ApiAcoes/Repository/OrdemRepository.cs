using System;
using System.Collections.Generic;
using System.Linq;
using ApiAcoes.Context;
using ApiAcoes.Models;
using ApiAcoes.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ApiAcoes.Repository
{
    public class OrdemRepository : IOrdemRepository
    {
        public IList<Ordem> Get(Func<Ordem, bool> where)
        {
            using (var context = new BtgDbContext())
            {
                return context
                    .Set<Ordem>()
                    .AsNoTracking()
                    .Where(where)
                    .ToList();
            }
        }

        public IList<Ordem> GetAll()
        {
            using (var context = new BtgDbContext())
            {
                return context
                    .Set<Ordem>()
                    .AsNoTracking()
                    .ToList();
            }
        }

        public Ordem GetOne(Func<Ordem, bool> where)
        {
            using (var context = new BtgDbContext())
            {
                return context
                    .Set<Ordem>()
                    .AsNoTracking()
                    .FirstOrDefault(where);
            }
        }

        public bool TryAdd(params Ordem[] items)
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
    }
}
