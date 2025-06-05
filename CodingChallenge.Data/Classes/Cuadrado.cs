using System.Reflection.Emit;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : ImprimerFiguraGeometrica, IFormaGeometrica
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public TipoFormaGeometrica Tipo => TipoFormaGeometrica.Cuadrado;

        public decimal Area => _lado * _lado;

        public decimal Perimetro => _lado * 4;

        protected override string ToString(int cantidad, Babel babel)
        {
            return cantidad == 1 ? babel.echo("Circulo") : babel.echo("Circulos");
        }
    }
} 