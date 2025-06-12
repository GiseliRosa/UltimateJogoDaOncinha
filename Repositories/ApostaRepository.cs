using JogoDaOncinha.Data;
using JogoDaOncinha.Models;

namespace JogoDaOncinha.Repositories
{
    // Herda de GenericRepository e implementa métodos genéricos automaticamente
    public class ApostaRepository : GenericRepository<Aposta>
    {
        public ApostaRepository(AppDbContext context) : base(context)
        {
        }

    }
}
