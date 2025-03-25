using Events_PLUS.Domains;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlus_.Domains
{
    [Table("PresencasEventos")]
    public class PresencasEventos
    {
        [Key]
        public Guid PresencasEventosID { get; set; }

        [Column(TypeName = "BIT")]
        public bool? Situacao { get; set; }


        [Required(ErrorMessage = "O usuario é obrigatório")]
        public Guid UsuarioID { get; set; }

        [ForeignKey("UsuarioID")]
        public Usuarios? Usuario { get; set; }


        [Required(ErrorMessage = "O evento é obrigatório")]
        public Guid EventosID { get; set; }

        [ForeignKey("EventosID")]
        public Eventos? Eventos { get; set; }
    }
}