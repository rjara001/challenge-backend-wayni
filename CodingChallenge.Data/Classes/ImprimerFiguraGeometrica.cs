using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class ImprimerFiguraGeometrica
    {
        public string Imprimir(Agrupador agrupador, Babel babel)
        {
            return $"{agrupador.Cantidad} {this.ToString(agrupador.Cantidad, babel)} | {babel.echo("Area")} {agrupador.TotalArea:#.##} | {babel.echo("Perimetro")} {agrupador.TotalPerimetro:#.##} <br/>";
        }
        protected virtual string ToString(int cantidad, Babel babel)
        {
            throw new NotImplementedException();
        }
    }
}
