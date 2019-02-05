using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAcoes.Models
{
    [Table("Ordem")]
    public class Ordem
    {
        [Key]
        public int IdOrdem { get; set; }
        public int TipoOrdem { get; set; }
        public DateTime DataOrdem { get; set; }
        public int QtdeAcoes { get; set; }
        public DateTime DataCompra { get; set; }
        public decimal? ValorCompra { get; set; }
        public decimal? TaxaCorretagem { get; set; }
        public decimal? IR { get; set; }

        [ForeignKey("Cliente")]
        public int IdCliente { get; set; }

        [ForeignKey("Acao")]
        public string IdAcao { get; set; }

        public virtual Cliente Cliente { get; set; }
        public virtual Acao Acao { get; set; }

    }
}
