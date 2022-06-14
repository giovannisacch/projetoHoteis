namespace ProjetoHoteis.lib.Models
{
    public class Quarto
    {
        public int Numero { get; set; }
        public int Andar { get; set; }

        public Quarto(int numero, int andar)
        {
            SetNumero(numero);
            SetAndar(andar);
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