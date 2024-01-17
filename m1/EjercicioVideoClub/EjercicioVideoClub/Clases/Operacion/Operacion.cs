namespace EjercicioVideoClub.Clases;

public class Operacion
{
    public Operacion(Socio socio, List<Pelicula> peliculas, FormatoExistencia formato, double monto, DateTime fecha)
    {
        Peliculas = peliculas;
        Formato = formato;
        Monto = monto;
        Fecha = fecha;
        Socio = socio;
    }
    public List<Pelicula> Peliculas { get; set; }
    public FormatoExistencia Formato { get; set; }
    public double Monto { get; set; }
    public DateTime Fecha { get; set; }
    public Socio Socio { get; }
}