using ProjetoHoteis.lib.Models;

namespace ProjetoHoteis.lib.Data.Repositorios
{
    public class TipoDeQuartoRepositorio : RepositorioBase<TipoDeQuarto>
    {
        private readonly HoteisContext _context;
        public TipoDeQuartoRepositorio(HoteisContext context) : base(context, context.TiposDeQuartos)
        {
            _context = context;
        }
    }
}