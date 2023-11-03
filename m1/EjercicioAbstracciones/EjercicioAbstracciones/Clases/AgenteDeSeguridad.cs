using System;

namespace EjercicioAbstracciones
{
    public class AgenteDeSeguridad : Oficio
    {
        public AgenteDeSeguridad(double salario, int antiguedad, CuentaBancaria cuentaBancaria) : base(salario, antiguedad, cuentaBancaria) {}
        
        public override void Trabajar(string nombreDelEmpleado)
        {
            Console.WriteLine($"{nombreDelEmpleado} se encuentra trabajando de seguridad...");
        }
    }
}