using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlus_.Domains
{
    [Table("TiposEventos")]
    public class TiposEventos
    {
        [Key]
        public Guid TiposEventosID { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O titulo do tipo evento é obrigatório!")]
        public string? TituloTipoEvento { get; set; }

    }
}