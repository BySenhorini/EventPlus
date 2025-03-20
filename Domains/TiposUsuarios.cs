using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events_PLUS.Domains
{
    [Table("TiposUsuarios")]
    public class TiposUsuarios
    {
        // Implementando a Foreign KEY TipoUsuarioId
        [Key]
        public Guid TipoUsuarioId { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O titulo de usuario é ")]
        public string? TituloTipoUsuario { get; set; }
    }
}

