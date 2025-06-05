/*
 * Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
 * agregar más formas geométricas?
 *
 * Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.
 *
 * TODO: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 * */

using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using static CodingChallenge.Data.Classes.Agrupador;

namespace CodingChallenge.Data.Classes
{
   
    public class FormaGeometrica
    {
        
        public FormaGeometrica()
        {
            
        }

        public static string Imprimir(List<IFormaGeometrica> formas, Babel babel)
        {
            babel.Cargar();

            var sb = new StringBuilder();

            if (formas.Count()==0)
            {
                sb.Append($"<h1>{babel.echo("empty-list-shapes")}</h1>");
            }
            else
            {

                sb.Append($"<h1>{babel.echo("report-title")}</h1>");

                GestorReporteFormaGeometrica _gestorReporte = new GestorReporteFormaGeometrica(babel);

                for (var i = 0; i < formas.Count; i++)
                {
                    _gestorReporte.CalcularAreaYPerimetro(formas[i]);
                }

                sb.Append(_gestorReporte.Imprimir());
            }

            return sb.ToString();
        }

    }
}
