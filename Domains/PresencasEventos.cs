using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Events_PLUS.Domains
{
    [Table("PresencaEventos")]
    public class PresencasEventos
    {
        // Foreign Key
        [Key]
        public Guid IdPresenca { get; set; }

        // Presença Obrigatória
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "A presença é obrigatório!")]
        public string? Presenca { get; set; }

        // IdUsuario
        public Guid IdUsuario { get; set; }
        [ForeignKey("IdUsuario")]
        public Usuarios? IdUsuarios { get; set; }

        // IdEvento
        public Guid IdEvento { get; set; }

        [ForeignKey("IdEvento")]
        public Eventos? Evento { get; set; }
    }
}
