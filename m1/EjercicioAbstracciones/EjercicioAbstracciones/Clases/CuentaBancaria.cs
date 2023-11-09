namespace EjercicioAbstracciones
{
    public class CuentaBancaria
    {
        public CuentaBancaria(int cbu, double saldo)
        {
            Cbu = cbu;
            Saldo = saldo;
        }
        public int Cbu { get; set; }
        public double Saldo { get; set; }
    }
}