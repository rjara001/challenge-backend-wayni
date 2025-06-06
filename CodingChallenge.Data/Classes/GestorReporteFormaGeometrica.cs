using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace CodingChallenge.Data.Classes
{
    public class Agrupador
    {
        public int Cantidad { get; set; }
        public decimal TotalArea { get; private set; }
        public decimal TotalPerimetro { get; private set; }
        IFormaGeometrica FormaGeometrica { get; set; }

        public class GestorReporteFormaGeometrica
        {

            IDictionary<TipoFormaGeometrica, Agrupador> _agrupadores = new Dictionary<TipoFormaGeometrica, Agrupador>();
            private readonly Babel babel;

            public GestorReporteFormaGeometrica(Babel babel)
            {
                this.babel = babel;
            }

            public void CalcularAreaYPerimetro(IFormaGeometrica formaGeometrica)
            {
                if (formaGeometrica == null)
                {
                    throw new ArgumentNullException(nameof(formaGeometrica), "La forma geométrica no puede ser nula.");
                }

                decimal area = formaGeometrica.Area;
                decimal perimetro = formaGeometrica.Perimetro;

                Agrupador _contador = null;

                if (!_agrupadores.ContainsKey(formaGeometrica.Tipo))
                {
                    _contador = new Agrupador() { Cantidad = 0, FormaGeometrica = formaGeometrica };

                    _agrupadores.Add(formaGeometrica.Tipo, _contador);
                }
                else
                    _contador = _agrupadores[formaGeometrica.Tipo];

                _contador.Cantidad++;
                _contador.TotalArea += area;
                _contador.TotalPerimetro += perimetro;
            }

            internal string Imprimir()
            {
                var sb = new StringBuilder();
                sb.Append(_obtenerLinea());
                sb.Append(_total());

                return sb.ToString();
            }

            private string _obtenerLinea()
            {
                var sb = new StringBuilder();
                foreach (var item in this._agrupadores.Values)
                {
                    sb.Append(item.FormaGeometrica.Imprimir(item, this.babel));  //$"{item.Cantidad} {babel.echo(item.Type.ToString(item.Cantidad))} | Area {item.Area:#.##} | Perimeter {item.Perimetro:#.##} <br/>");
                }

                return sb.ToString();
            }

            private string _total()
            {
                var totalCantidad = this._agrupadores.Values.Sum(item => item.Cantidad);
                var totalArea = this._agrupadores.Values.Sum(item => item.TotalArea);
                var totalPerimetro = this._agrupadores.Values.Sum(item => item.TotalPerimetro);

                return $"TOTAL:<br/>{totalCantidad} {babel.echo("shapes")} {babel.echo("perimeter")} {totalPerimetro:#.##} {babel.echo("area")} {totalArea:#.##}";

            }
        }
    }
}