using ApiAcoes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAcoes.Repository.Interfaces
{
    public interface IOrdemRepository
    {
        Ordem GetOne(Func<Ordem, bool> where);
        IList<Ordem> GetAll();
        IList<Ordem> Get(Func<Ordem, bool> where);
        bool TryAdd(params Ordem[] items);
    }
}
