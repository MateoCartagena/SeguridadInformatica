namespace SeguridadInformatica.Models
{
    public class RiesgoPorActivo
    {
        public int Id_Activo { get; set; }
        public int Id_Riesgo { get; set; }
        public List<Activo> Activos { get; set; } = new List<Activo>();
        public List<Riesgo> Riesgos { get; set; } = new List<Riesgo>();

    }
}
