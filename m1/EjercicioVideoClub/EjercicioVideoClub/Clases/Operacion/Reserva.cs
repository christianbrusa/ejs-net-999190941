namespace EjercicioVideoClub.Clases;

public enum DuracionAlquiler
{
    Horas24 = 24,
    Horas48 = 48,
    Horas72 = 72
}
public class Reserva : Operacion
{
    public Reserva(Socio socio, List<Pelicula> peliculas, FormatoExistencia formato, double monto, DateTime fecha, DuracionAlquiler duracion) : base(socio, peliculas, formato, monto, fecha)
    {
        Duracion = duracion;
    }
    public DuracionAlquiler Duracion { get; set; }
}