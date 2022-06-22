using ProjetoHoteis.lib.Models;

namespace ProjetoHoteis.lib.Data.Repositorios
{
    public class EstadiaRepositorio : RepositorioBase<Estadia>
    {
        private readonly HoteisContext _context;
        public EstadiaRepositorio(HoteisContext context) : base (context, context.Estadias)
        {
            _context = context;
        }
    }
}