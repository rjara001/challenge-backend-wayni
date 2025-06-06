namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : ImprimerFiguraGeometrica, IFormaGeometrica
    {
        private readonly decimal _ancho;
        private readonly decimal _alto;

        public Rectangulo(decimal ancho, decimal alto)
        {
            _ancho = ancho;
            _alto = alto;
        }

        public TipoFormaGeometrica Tipo => TipoFormaGeometrica.Rectangulo;

        public decimal Area => _ancho * _alto;

        public decimal Perimetro => 2 * (_ancho + _alto);
        protected override string ToString(int cantidad, Babel babel)
        {
            return cantidad == 1 ? babel.echo("rectangule") : babel.echo("rectangules");
        }
    }
}