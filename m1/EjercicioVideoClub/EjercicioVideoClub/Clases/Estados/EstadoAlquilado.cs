namespace EjercicioVideoClub.Clases.Estados;

public class EstadoAlquilado : IEstado
{
    public void Alquilar(Pelicula pelicula, string formato)
    {
        throw new Exception($"La pelicula {pelicula.Titulo} no se encuentra disponible");
    }

    public void Devolver(Pelicula pelicula, string formato)
    {
        //not implemented
    }

    public void Reservar(Pelicula pelicula, string formato)
    {
        //not implemented
    }
}