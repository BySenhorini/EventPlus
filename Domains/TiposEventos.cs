using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events_PLUS.Domains
{
    [Table("TiposEventos")]
    public class TiposEventos
    {
        // Foreign Key
        [Key]
        public Guid IdTipoEvento { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O Tipo de Evento é obrigatório!")]
        public string? TituloTipoEvento { get; set; }
    }
}
