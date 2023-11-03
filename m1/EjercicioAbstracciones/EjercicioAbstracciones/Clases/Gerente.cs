using System;

namespace EjercicioAbstracciones
{
    public class Gerente : Oficio
    {
        public Gerente(double salario, int antiguedad, CuentaBancaria cuentaBancaria) : base(salario, antiguedad, cuentaBancaria) {}
        
        public override void Trabajar(string nombreDelEmpleado)
        {
            Console.WriteLine($"{nombreDelEmpleado} se encuentra trabajando de gerente...");
        }
    }
}