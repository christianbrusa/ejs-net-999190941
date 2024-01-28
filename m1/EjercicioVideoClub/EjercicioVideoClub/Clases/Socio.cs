namespace EjercicioVideoClub.Clases;

public class Socio
{
    public Socio(int id, string nombreCompleto, int telefono)
    {
        Id = id;
        NombreCompleto = nombreCompleto;
        Telefono = telefono;
    }
    public int Id { get; set; }
    public string NombreCompleto { get; set; }
    public int Telefono { get; set; }
    public void Alquilar(Operacion operacion)
    {
        operacion.Peliculas.ForEach(pelicula => pelicula.Alquilar(operacion.Formato));
    }

    public void Reservar(Operacion operacion)
    {
        operacion.Peliculas.ForEach(pelicula => pelicula.Reservar(operacion.Formato));
    }
}