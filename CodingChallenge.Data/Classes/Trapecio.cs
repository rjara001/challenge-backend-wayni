using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : ImprimerFiguraGeometrica, IFormaGeometrica
    {
        private readonly decimal baseMayor;
        private readonly decimal baseMenor;
        private readonly decimal altura;
        private readonly decimal ladoNoParalelo;

        public Trapecio(decimal baseMayor, decimal baseMenor, decimal altura, decimal ladoNoParalelo)
        {
            this.baseMayor = baseMayor;
            this.baseMenor = baseMenor;
            this.altura = altura;
            this.ladoNoParalelo = ladoNoParalelo;
        }

        public TipoFormaGeometrica Tipo => TipoFormaGeometrica.Trapecio;

        public decimal Area => (baseMayor + baseMenor) / 2 * altura;

        public decimal Perimetro => baseMayor + baseMenor + 2 * ladoNoParalelo;

        protected override string ToString(int cantidad, Babel babel)
        {
            return cantidad == 1 ? babel.echo("trapezium") : babel.echo("trapeziumes");
        }
    }

}
