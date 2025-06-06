using System;
using System.Reflection.Emit;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : ImprimerFiguraGeometrica, IFormaGeometrica
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public TipoFormaGeometrica Tipo => TipoFormaGeometrica.TrianguloEquilatero;

        public decimal Area => ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;

        public decimal Perimetro => _lado * 3;
        protected override string ToString(int cantidad, Babel babel)
        {
            return cantidad == 1 ? babel.echo("triangle") : babel.echo("triangles");
        }
    }
}