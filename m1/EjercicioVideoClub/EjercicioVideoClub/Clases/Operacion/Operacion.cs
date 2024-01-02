namespace EjercicioVideoClub.Clases;

public class Operacion
{
    public Operacion(Socio socio, List<Pelicula> peliculas, string formato, double monto, DateTime fecha)
    {
        Peliculas = peliculas;
        Formato = formato;
        Monto = monto;
        Fecha = fecha;
    }
    public List<Pelicula> Peliculas { get; set; }
    public string Formato { get; set; }
    public double Monto { get; set; }
    public DateTime Fecha { get; set; }
}