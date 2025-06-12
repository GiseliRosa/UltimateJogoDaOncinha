using JogoDaOncinha.Data;
using JogoDaOncinha.Models;
using Microsoft.EntityFrameworkCore;

namespace JogoDaOncinha.Repositories
{
    // Herda de GenericRepository e implementa métodos genéricos automaticamente
    public class JogoRepository : GenericRepository<Jogo>
    {
        // A injeção de dependência do AppDbContext garante que o repositório não cria sua própria instância
        public JogoRepository(AppDbContext context) : base(context)
        {
        }

    }
}
