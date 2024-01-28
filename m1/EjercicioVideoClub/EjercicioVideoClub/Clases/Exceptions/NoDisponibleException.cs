namespace EjercicioVideoClub.Clases.Exceptions;

public class NoDisponibleException : Exception
{
    public NoDisponibleException() : base("Error, una película sin existencias no puede estar disponible") { }
    
    public NoDisponibleException(string titulo) : base($"La película {titulo} no se encuentra disponible") { }
}