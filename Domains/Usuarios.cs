using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events_PLUS.Domains
{
    public class Usuarios
    {
        // Foreign Key
        [Key]
        public Guid IdUsuario { get; set; }

        // Usuário
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O Usuário é obrigatório!")]
        public string? Usuario { get; set; }

        // Nome do Usuário
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O Nome do Usuário é obrigatório!")]
        public string? NomeUsuario { get; set; }

        // Nome do Email do Usuário
        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O Nome do Email do Usuário é obrigatório!")]
        public string? Email { get; set; }

        // Nome da Senha do Usuário
        [Column(TypeName = "VARCHAR(60)")]
        [Required(ErrorMessage = "A Senha do Usuário é obrigatório!")]
        public string? Senhas { get; set; }

        //--------------------------------------------------------------------------------
        // FK do IDTipoUsuário
        public Guid IdTipoUsuario { get; set; }
        [ForeignKey("IdTipoUsuario")]
        public TiposUsuarios? TiposUsuario { get; set; }
        }
    }

