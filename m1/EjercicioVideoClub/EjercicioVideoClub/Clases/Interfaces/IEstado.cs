namespace EjercicioVideoClub.Clases;

public interface IEstado
{
    void Alquilar(Pelicula pelicula, FormatoExistencia formato);
    void Devolver(Pelicula pelicula, FormatoExistencia formato);
    void Reservar(Pelicula pelicula, FormatoExistencia formato);
}