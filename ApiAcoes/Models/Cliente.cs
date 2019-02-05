using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiAcoes.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        public Cliente()
        {
            Ordens = new List<Ordem>();
        }

        [Key]
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char TipoPessoa { get; set; }
        public string CpfCnpj { get; set; }

        public virtual ICollection<Ordem> Ordens { get; set; }
    }
}
