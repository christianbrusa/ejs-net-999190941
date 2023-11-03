using System;
using System.Collections.Generic;

namespace EjercicioAbstracciones
{
    public class Empleado : Persona
    {
        public Empleado(string nombre, string apellido, string dni, Direccion domicilio, Auto vehiculo, List<Oficio> oficios) : base(nombre, apellido, dni, domicilio, vehiculo)
        {
            this.Oficios = oficios;
        }

        public List<Oficio> Oficios { get; set; }

        public void Trabajar()
        {
            foreach (Oficio oficio in Oficios)
            {
                oficio.Trabajar(this.Nombre);
            }
        }
    }
}