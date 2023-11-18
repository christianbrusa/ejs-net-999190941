using System;
using System.Collections.Generic;

namespace EjercicioAbstracciones
{
    public class Empleado : Persona
    {
        public Empleado(string nombre, string apellido, string dni, Direccion domicilio, Auto vehiculo, IList<Oficio> oficios) : base(nombre, apellido, dni, domicilio, vehiculo)
        {
            Oficios = oficios;
        }

        public IList<Oficio> Oficios { get; set; }

        public void Trabajar()
        {
            foreach (var oficio in Oficios)
            {
                oficio.Trabajar(Nombre);
            }
        }
    }
}