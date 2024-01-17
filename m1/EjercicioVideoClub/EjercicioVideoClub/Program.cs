using System;
using EjercicioVideoClub.Clases;
using EjercicioVideoClub.Clases.Estados;

namespace EjercicioVideoClub
{
    class Program
    {
        static void Main(string[] args)
        {
            var pepe = new Socio(1, "Jose Argento", 1122334455);
            var copiasPelicula1 = new List<Existencia>
            {
                new Existencia(FormatoExistencia.DVD, copias: 0),
                new Existencia(FormatoExistencia.VHS, copias: 0)
            };
            var pelicula1 = new Pelicula("El secreto de sus ojos", 3000, copiasPelicula1, new EstadoDisponible());
            var peliculasOperacion1 = new List<Pelicula> { pelicula1 };
            DateTime fechaInicioOperacion1 = new DateTime(2023, 1, 10);
            DateTime fechaDevolucionOperacion1 = new DateTime(2023, 1, 12);
            var operacion1 = new Alquiler(pepe, peliculasOperacion1, FormatoExistencia.VHS, 50, fechaInicioOperacion1, fechaDevolucionOperacion1);

            pepe.Alquilar(operacion1);
        }
    }
}