using Microsoft.EntityFrameworkCore;
using ProjetoHoteis.lib.Models;

namespace ProjetoHoteis.lib.Data.Repositorios
{
    public class RepositorioBase<T> where T : ModelBase
    {
        private readonly HoteisContext _context;
        private readonly DbSet<T> _dbset;
        public RepositorioBase(HoteisContext context, DbSet<T> dbset)
        {
            _context = context;
            _dbset = dbset;
        }

        public List<T> BuscarTodos()
        {
            return _dbset.AsNoTracking().ToList();
        }

        public T BuscarPorId(int id)
        {
            var retorno = _dbset.AsNoTracking().First(x => x.Id == id);
            return retorno;
        }

        public void Adicionar(T item)
        {
            _dbset.Add(item);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            var item = _dbset.Find(id);
            _dbset.Remove(item);
            _context.SaveChanges();
        }
    }
}