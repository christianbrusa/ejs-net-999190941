namespace EjercicioAbstracciones
{
    public class Auto
    {
        public Auto(string marca, string modelo, int anio, int litrosDeCombustible)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            LitrosDeCombustible = litrosDeCombustible;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public int LitrosDeCombustible { get; set; }
    }
}