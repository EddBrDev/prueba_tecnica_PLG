using System.Diagnostics.Metrics;

namespace API.Models
{
    public class Cliente
    {
        public int id_cliente { get; set; }
        public string? cliente { get; set; }
        public string? telefono { get; set; }
        public string? pais { get; set; }
    }
}
