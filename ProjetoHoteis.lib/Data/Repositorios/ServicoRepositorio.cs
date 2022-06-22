using ProjetoHoteis.lib.Models;

namespace ProjetoHoteis.lib.Data.Repositorios
{
    public class ServicoRepositorio : RepositorioBase<Servico>
    {
        private readonly HoteisContext _context;
        public ServicoRepositorio(HoteisContext context) : base(context, context.Servicos)
        {
            _context = context;
        }
    }
}