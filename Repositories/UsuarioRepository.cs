using JogoDaOncinha.Data;
using JogoDaOncinha.Models;

namespace JogoDaOncinha.Repositories
{
    // Herda de GenericRepository e implementa métodos genéricos automaticamente
    public class UsuarioRepository : GenericRepository<Usuario>
    {
        public UsuarioRepository(AppDbContext context) : base(context)
        {
        }

    }
}
