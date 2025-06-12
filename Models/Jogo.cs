using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaOncinha.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string TimeCasa { get; set; }
        public string TimeVisitante { get; set; }
        public decimal OddCasa { get; set; }
        public decimal OddVisitante { get; set; }
    }
}
