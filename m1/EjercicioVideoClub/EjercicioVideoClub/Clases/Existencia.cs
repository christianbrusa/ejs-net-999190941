namespace EjercicioVideoClub.Clases;

public class Existencia
{
    public Existencia(string formato, int copias)
    {
        Formato = formato;
        Copias = copias;
    }
    public string Formato { get; set; }
    public int Copias { get; set; }
    public bool TieneCopiasDisponibles()
    {
        return Copias > 0;
    }
}