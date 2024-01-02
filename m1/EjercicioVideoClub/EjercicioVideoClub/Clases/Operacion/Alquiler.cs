namespace EjercicioVideoClub.Clases;

public class Alquiler : Operacion
{
    public Alquiler(Socio socio, List<Pelicula> peliculas, string formato, double monto, DateTime fecha, DateTime devolucion) : base(socio, peliculas, formato, monto, fecha)
    {
        Devolucion = devolucion;
    }
    public DateTime Devolucion { get; set; }
}