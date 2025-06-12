using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaOncinha.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public decimal Saldo { get; set; }

        // Relacionamento com apostas 1:N, um usuario pode ter varias apostas
        public ICollection<Aposta> Apostas
        {
            get; set;
        }
    }
}
