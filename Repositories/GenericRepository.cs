using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JogoDaOncinha.Data;
using JogoDaOncinha.Interfaces;

namespace JogoDaOncinha.Repositories
{

    /* Aqui é o coração da inteintegração com o banco de dados, é um código reutilizável que funciona como qualquer entidade
     * Ela implementa a interface IRepository<T> e aceita qualquer classe (T) que seja uma entidade do Entity Framework.
     * Não é preciso repetir o mesmo código para cada entidade, apenas criar uma instância do repositório genérico.
     * Dessa forma é possível estender o projeto sem precisar modificar muito o código existente.
     * Também ajuda a alterar o banco de dados, pois a lógica de acesso ao banco está centralizada aqui.
     */
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var entity = _dbSet.Find(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                _context.SaveChanges();
            }
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
    }
}
