namespace EjercicioVideoClub.Clases.Estados;

public class EstadoDisponible : IEstado
{
    public void Alquilar(Pelicula pelicula, string formato)
    {
        var existenciaFormatoElegido = pelicula.Existencia.Where(copia => copia.Formato == formato).ToList();
        ModificarExistencia(existenciaFormatoElegido);
        if (!QuedanCopiasEnAlgunFormato(pelicula))
        {
            pelicula.Estado = new EstadoAlquilado();
        }
    }

    public void Devolver(Pelicula pelicula, string formato)
    {
        //not implemented
    }

    public void Reservar(Pelicula pelicula, string formato)
    {
        //not implemented
    }
    private void ModificarExistencia(List<Existencia> existenciaPelicula)
    {
        existenciaPelicula[0].Copias -= 1;
    }
    private bool QuedanCopiasEnAlgunFormato(Pelicula pelicula)
    {
        return pelicula.Existencia.Any(existencia => existencia.TieneCopiasDisponibles());
    }
}