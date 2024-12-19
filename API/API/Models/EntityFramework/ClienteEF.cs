using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.Models.EntityFramework
{
    public class ClienteEF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_cliente { get; set; }
        public string? cliente { get; set; }
        public string? telefono { get; set; }
        public int id_pais { get; set; }
        [ForeignKey("id_pais")]
        public virtual PaisEF? Pais_Ef { get; set; }
    }
}
