namespace EjercicioAbstracciones
{
    public class Direccion
    {
        public Direccion(string calle, int codigoPostal, string ciudad)
        {
            this.Calle = calle;
            this.CodigoPostal = codigoPostal;
            this.Ciudad = ciudad;
        }
        
        public string Calle { get; set; }
        public int CodigoPostal { get; set; }
        public string Ciudad { get; set; }
    }
}