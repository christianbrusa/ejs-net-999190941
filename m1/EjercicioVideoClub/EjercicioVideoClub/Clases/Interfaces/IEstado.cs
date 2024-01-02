namespace EjercicioVideoClub.Clases;

public interface IEstado
{
    void Alquilar(Pelicula pelicula, string formato);
    void Devolver(Pelicula pelicula, string formato);
    void Reservar(Pelicula pelicula, string formato);
}