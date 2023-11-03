namespace EjercicioAbstracciones
{
    public class Oficio
    {
        public Oficio(double salario, int antiguedad, CuentaBancaria cuentaBancaria)
        {
            this.Salario = salario;
            this.Antiguedad = antiguedad;
            this.CuentaBancaria = cuentaBancaria;
        }
        
        public double Salario { get; set; }
        public int Antiguedad { get; set; }
        public CuentaBancaria CuentaBancaria { get; set; }
        
        public virtual void Trabajar(string nombreDelEmpleado) {}
    }
}