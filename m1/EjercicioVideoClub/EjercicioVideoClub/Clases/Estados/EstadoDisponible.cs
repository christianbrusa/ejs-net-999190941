namespace EjercicioVideoClub.Clases.Estados;

public class EstadoDisponible : IEstado
{
    public void Alquilar(Pelicula pelicula, FormatoExistencia formato)
    {
        var existenciaFormatoElegido = pelicula.Existencia.First(copia => copia.Formato == formato);
        ModificarExistencia(existenciaFormatoElegido);
        if (!QuedanCopiasEnAlgunFormato(pelicula))
        {
            pelicula.Estado = new EstadoAlquilado();
        }
    }

    public void Devolver(Pelicula pelicula, FormatoExistencia formato)
    {
        //not implemented
    }

    public void Reservar(Pelicula pelicula, FormatoExistencia formato)
    {
        //not implemented
    }
    private void ModificarExistencia(Existencia existenciaPelicula)
    {
        existenciaPelicula.Copias -= 1;
    }
    private bool QuedanCopiasEnAlgunFormato(Pelicula pelicula)
    {
        return pelicula.Existencia.Any(existencia => existencia.TieneCopiasDisponibles());
    }
}