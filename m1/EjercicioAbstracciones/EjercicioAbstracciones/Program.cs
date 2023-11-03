using System;
using System.Collections.Generic;

namespace EjercicioAbstracciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto vehiculo1 = new Auto("Audi", "Q5", 2023, 20);
            Direccion domicilio1 = new Direccion("Brandsen 805", 1161, "Caba");
            
            CuentaBancaria cuentaGalicia1 = new CuentaBancaria(1111, 0);
            CuentaBancaria cuentaGalicia2 = new CuentaBancaria(2222, 0);
            CuentaBancaria cuentaGalicia3 = new CuentaBancaria(3333, 0);

            AgenteDeSeguridad seguridad1 = new AgenteDeSeguridad(120000, 2, cuentaGalicia1);
            Gerente gerente1 = new Gerente(300000, 1, cuentaGalicia2);
            Secretaria secretaria1 = new Secretaria(200000, 4, cuentaGalicia3);
            List<Oficio> oficiosDePepe = new List<Oficio> { seguridad1, gerente1 };
            List<Oficio> oficiosDeMarta = new List<Oficio> { secretaria1 };
            
            Empleado persona1 = new Empleado("Raul", "", "11111111", domicilio1, vehiculo1, oficiosDePepe);
            Empleado persona2 = new Empleado("Marta", "", "22222222", domicilio1, vehiculo1, oficiosDeMarta);
            
            persona1.Trabajar();
            persona2.Trabajar();
        }
    }
}