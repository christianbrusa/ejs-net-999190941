﻿namespace EjercicioVideoClub.Clases.Estados;

public class EstadoDisponible : IEstado
{
    public void Alquilar(Pelicula pelicula, FormatoExistencia formato)
    {
        GestionarExistencia(pelicula, formato);
        GestionarEstado(pelicula, new EstadoAlquilado());
    }

    public void Devolver(Pelicula pelicula, FormatoExistencia formato)
    {
        //not implemented
    }

    public void Reservar(Pelicula pelicula, FormatoExistencia formato)
    {
        GestionarExistencia(pelicula, formato);
        GestionarEstado(pelicula, new EstadoReservado());
    }

    private void GestionarExistencia(Pelicula pelicula, FormatoExistencia formato)
    {
        var existenciaFormatoElegido = pelicula.Existencia.First(copia => copia.Formato == formato);
        if (existenciaFormatoElegido.Copias <= 0) throw new Exception("Error, no hay copias disponibles para este formato");
        ModificarExistencia(existenciaFormatoElegido);
    }

    private void GestionarEstado(Pelicula pelicula, IEstado estado)
    {
        if (!QuedanCopiasEnAlgunFormato(pelicula))
        {
            pelicula.Estado = estado;
        }
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