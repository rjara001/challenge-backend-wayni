using System;
using System.Reflection.Emit;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : ImprimerFiguraGeometrica, IFormaGeometrica
    {
        private readonly decimal _radio;
        public Circulo(decimal radio)
        {
            _radio = radio;
        }

        public TipoFormaGeometrica Tipo => TipoFormaGeometrica.Circulo;

        public decimal Area => (decimal)Math.PI * (_radio / 2) * (_radio / 2);

        public decimal Perimetro => (decimal)Math.PI * _radio;

        protected override string ToString(int cantidad, Babel babel)
        {
            return cantidad == 1 ? babel.echo("Circulo") : babel.echo("Circulos");
        }
    }
}