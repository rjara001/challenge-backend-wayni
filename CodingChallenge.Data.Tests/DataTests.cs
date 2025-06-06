using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), new Babel(TipoIdioma.Castellano)));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<IFormaGeometrica>(), new Babel(TipoIdioma.Ingles)));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<IFormaGeometrica> { new Cuadrado(5) };

            var resumen = FormaGeometrica.Imprimir(cuadrados, new Babel(TipoIdioma.Castellano));

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, new Babel(TipoIdioma.Ingles));

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, new Babel(TipoIdioma.Ingles));

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 shapes Perimeter 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public static void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            var resumen = FormaGeometrica.Imprimir(formas, new Babel(TipoIdioma.Castellano));

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Circulos | Area 13.01 | Perimetro 18.06 <br/>3 Triangulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 formas Perimetro 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConRectangulo()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Rectangulo(6, 4)
            };

            var resumen = FormaGeometrica.Imprimir(formas, new Babel(TipoIdioma.Frances));

            Assert.AreEqual("<h1>Rapport de Formes</h1>1 Rectangle | Surface 24 | Périmètre 20 <br/>TOTAL:<br/>1 formes Périmètre 20 Surface 24", resumen);
        }

        [TestCase]
        public void TestResumenConUnTrapecioEnCastellano()
        {
            var formas = new List<IFormaGeometrica>
            {
                new Trapecio(10, 6, 4, 5) // base mayor, base menor, altura, lado no paralelo
            };

            var resumen = FormaGeometrica.Imprimir(formas, new Babel(TipoIdioma.Castellano));

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Trapecio | Area 32 | Perimetro 26 <br/>TOTAL:<br/>1 formas Perimetro 26 Area 32", resumen);

        }

        [TestCase]
        public void TestResumenConUnTrapecioEnFrances()
        {
            var formas = new List<IFormaGeometrica>
    {
        new Trapecio(10, 6, 4, 5)
    };

            var resumen = FormaGeometrica.Imprimir(formas, new Babel(TipoIdioma.Frances));

            Assert.AreEqual("<h1>Rapport de Formes</h1>1 Trapèze | Surface 32 | Périmètre 26 <br/>TOTAL:<br/>1 formes Périmètre 26 Surface 32", resumen);
        }

    }
}
