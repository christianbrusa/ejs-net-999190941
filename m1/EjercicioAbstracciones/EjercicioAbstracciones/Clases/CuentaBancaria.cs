namespace EjercicioAbstracciones
{
    public class CuentaBancaria
    {
        public CuentaBancaria(int cbu, double saldo)
        {
            this.Cbu = cbu;
            this.Saldo = saldo;
        }
        public int Cbu { get; set; }
        public double Saldo { get; set; }
    }
}