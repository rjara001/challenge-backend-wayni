namespace CodingChallenge.Data.Classes
{
    public class AgrupadorFormaGeometrica : ITypeGroup
    {
        public Type Tipo { get; set; }
        public int Cantidad { get; set; }

        public AgrupadorFormaGeometrica(int tipo, int cantidad)
        {
            Tipo = tipo;
            Cantidad = cantidad;
        }
    }
}   