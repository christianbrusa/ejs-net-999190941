namespace EjercicioAbstracciones
{
    public class Persona
    {
        public Persona(string nombre, string apellido, string dni, Direccion domicilio, Auto vehiculo)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Domicilio = domicilio;
            Vehiculo = vehiculo;
        }
        
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public Direccion Domicilio { get; set; }
        public Auto Vehiculo { get; set; }
        
    }
}