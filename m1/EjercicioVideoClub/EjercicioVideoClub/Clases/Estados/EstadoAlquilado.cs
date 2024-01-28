using EjercicioVideoClub.Clases.Exceptions;

namespace EjercicioVideoClub.Clases.Estados;

public class EstadoAlquilado : IEstado
{
    public void Alquilar(Pelicula pelicula, FormatoExistencia formato)
    {
        throw new NoDisponibleException(pelicula.Titulo);
    }

    public void Devolver(Pelicula pelicula, FormatoExistencia formato)
    {
        //not implemented
    }

    public void Reservar(Pelicula pelicula, FormatoExistencia formato)
    {
        throw new NoDisponibleException(pelicula.Titulo);
    }
}