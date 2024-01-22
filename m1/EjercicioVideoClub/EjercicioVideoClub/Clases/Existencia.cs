namespace EjercicioVideoClub.Clases;

public enum FormatoExistencia
{
    DVD,
    VHS
}

public class Existencia
{
    public Existencia(FormatoExistencia formato, int copias)
    {
        Formato = formato;
        Copias = copias;
    }
    public FormatoExistencia Formato { get; set; }
    public int Copias { get; set; }
    public bool TieneCopiasDisponibles()
    {
        return Copias > 0;
    }
}