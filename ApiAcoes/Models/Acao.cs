using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAcoes.Models
{
    public class Acao
    {
        public string IdAcao { get; set; }
        public DateTime DataCotacao { get; set; }
        public decimal ValorCotacao { get; set; }

        public virtual Ordem Ordem { get; set; }
    }
}
