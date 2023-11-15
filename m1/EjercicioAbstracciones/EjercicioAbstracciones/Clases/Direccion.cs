namespace EjercicioAbstracciones
{
    public class Direccion
    {
        public Direccion(string calle, int codigoPostal, string ciudad)
        {
            Calle = calle;
            CodigoPostal = codigoPostal;
            Ciudad = ciudad;
        }
        
        public string Calle { get; set; }
        public int CodigoPostal { get; set; }
        public string Ciudad { get; set; }
    }
}