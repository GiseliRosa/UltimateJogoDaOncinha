using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaOncinha.Models
{
    public class Aposta
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public int JogoId { get; set; }
        public Jogo Jogo { get; set; }

        public string Escolha { get; set; } // "Casa" ou "Visitante"
        public decimal Valor { get; set; }

        public bool Finalizada { get; set; } = false; // Se a aposta foi finalizada ou não, vai ser usado para deletar apostas que já foram
        public string? Resultado { get; set; } // "Casa", "Visitante", ou "Empate"
    }
}
