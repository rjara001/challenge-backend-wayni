namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : IFormaGeometrica
    {
        private readonly decimal _ancho;
        private readonly decimal _alto;

        public Rectangulo(decimal ancho, decimal alto)
        {
            _ancho = ancho;
            _alto = alto;
        }

        public int Tipo => FormaGeometrica.Rectangulo;

        public decimal Area => _ancho * _alto;

        public decimal Perimetro => 2 * (_ancho + _alto);

        public string Imprimir(int idioma)
        {
            return FormaGeometrica.ObtenerLinea(1, Area, Perimetro, Tipo, idioma);
        }

        public string Imprimir()
        {
            return Imprimir(FormaGeometrica.Castellano);
        }
    }
}