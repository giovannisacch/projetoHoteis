namespace ProjetoHoteis.lib.Models
{
    public class Quarto : ModelBase
    {
        public virtual int IdTipo { get; set; }
        public virtual int IdHotel { get; set; }
        public int Numero { get; set; }
        public int Andar { get; set; }
        public virtual TipoDeQuarto Tipo { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual List<Estadia> Estadias { get; set; }

        public Quarto(int id, string dataCriacao, string ultimaVez, int numero, int andar) : base (id, dataCriacao, ultimaVez)
        {
            SetNumero(numero);
            SetAndar(andar);
        }
        public Quarto()
        {
            
        }

        public int GetNumero()
        {
            return Numero;
        }

        public void SetNumero(int numero)
        {
            Numero = numero;
        }

        public int GetAndar()
        {
            return Andar;
        }

        public void SetAndar(int andar)
        {
            Andar = andar;
        }
    }
}