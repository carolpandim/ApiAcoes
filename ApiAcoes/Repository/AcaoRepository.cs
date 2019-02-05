using ApiAcoes.Models;
using ApiAcoes.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAcoes.Repository
{
    public class AcaoRepository : Repository<Acao>, IAcaoRepository
    {
    }
}
