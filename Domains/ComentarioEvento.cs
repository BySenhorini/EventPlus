using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// As DOMAINS servem para criar as tabelas no seu Banco de Dados, cadastrar os tipos de Dados e seus Atributos.

namespace Events_PLUS.Domains
{
    [Table("ComentarioEvento")]
    public class ComentarioEvento
    {
        // Foreign Key 
        [Key]
        public Guid IdComentarioEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "A Descrição do comentário é obrigatória!")]
        public string? Descricao { get; set; }

        [Column(TypeName = "BIT")]
        [Required(ErrorMessage = "A Exibição do comentário é obrigatória!")]
        public bool? Exibe { get; set; }


        // Referência Tabela Usuário

        [Required(ErrorMessage = "O Nome do usuário é obrigatório!")]
        public Guid IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuarios? Usuarios { get; set; }


        // Referência Tabela Evento

        [Required(ErrorMessage = "O Nome do evento é obrigatório!")]
        public Guid IdEvento { get; set; }

        [ForeignKey("IdEvento")]
        public Eventos? Eventos { get; set; }
    }
}
