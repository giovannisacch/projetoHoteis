using ProjetoHoteis.lib.Models;

namespace ProjetoHoteis.lib.Data.Repositorios
{
    public class HotelRepositorio : RepositorioBase<Hotel>
    {
        private readonly HoteisContext _context;
        public HotelRepositorio(HoteisContext context) : base(context, context.Hoteis)
        {
            _context = context;
        }
    }
}