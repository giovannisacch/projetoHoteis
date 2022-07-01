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
        public async Task<List<T>> BuscarTodosAsync()
        {
            return await _dbset.AsNoTracking().ToListAsync();
        }

        public async Task<List<T>> BuscarTodos()
        {
            return await _dbset.AsNoTracking().ToListAsync();
        }

        public async Task<T> BuscarPorId(int id)
        {
            var retorno = await _dbset.AsNoTracking().FirstAsync(x => x.Id == id);
            return retorno;
        }

        public async Task Adicionar(T item)
        {
            await _dbset.AddAsync(item);
            await _context.SaveChangesAsync();
        }

        public async Task Deletar(int id)
        {
            var item = await _dbset.FindAsync(id);
            _dbset.Remove(item);
            await _context.SaveChangesAsync();
        }
    }
}