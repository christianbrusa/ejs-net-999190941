namespace EjercicioVideoClub.Clases;

public enum DuracionAlquiler
{
    // El prefijo Reserva solo lo puse porque los identificadores no pueden arrancar con un numero
    Reserva24Horas,
    Reserva48Horas,
    Reserva72Horas,
}

public class Reserva : Operacion
{
    public Reserva(Socio socio, List<Pelicula> peliculas, FormatoExistencia formato, double monto, DateTime fecha, DuracionAlquiler duracion) : base(socio, peliculas, formato, monto, fecha)
    {
        Duracion = duracion;
    }
    public DuracionAlquiler Duracion { get; set; }
}