using ProjetoHoteis.lib.Models;

namespace ProjetoHoteis.lib.Data.Repositorios
{
    public class QuartoRepositorio : RepositorioBase<Quarto>
    {
        private readonly HoteisContext _context;
        public QuartoRepositorio(HoteisContext context) : base(context, context.Quartos)
        {
            _context = context;
        }
    }
}