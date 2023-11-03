namespace EjercicioAbstracciones
{
    public class Persona
    {
        public Persona(string nombre, string apellido, string dni, Direccion domicilio, Auto vehiculo)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Dni = dni;
            this.Domicilio = domicilio;
            this.Vehiculo = vehiculo;
        }
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public Direccion Domicilio { get; set; }
        public Auto Vehiculo { get; set; }
        
    }
}