namespace EjercicioVideoClub.Clases;

public class Reserva : Operacion
{
    private static readonly List<int> DuracionesValidas = new List<int> { 24, 48, 72 };
    public Reserva(Socio socio, List<Pelicula> peliculas, string formato, double monto, DateTime fecha, int duracion) : base(socio, peliculas, formato, monto, fecha)
    {
        if (!EsDuracionValida(duracion))
        {
            throw new Exception("Error, la duración de la reserva debe ser 24, 48 o 72 horas");
        }
        Duracion = duracion;
    }
    public int Duracion { get; set; }
    
    private bool EsDuracionValida(int duracion)
    {
        return DuracionesValidas.Contains(duracion);
    }
}