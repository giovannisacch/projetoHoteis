using ProjetoHoteis.lib.Models;

namespace ProjetoHoteis.lib.Data.Repositorios
{
    public class HospedeRepositorio : RepositorioBase<Hospede>
    {
        private readonly HoteisContext _context;
        public HospedeRepositorio(HoteisContext context) : base(context, context.Hospedes)
        {
            _context = context;
        }
    }
}