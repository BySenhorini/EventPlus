using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events_PLUS.Domains
{
    [Table("Eventos")]
    public class Eventos
    {
        [Key]
        public Guid IdEvento { get; set; }

        // Data
        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A Data é obrigatória!")]
        public DateTime DataEvento { get; set; }

        // Nome do Evento
        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "O Nome do Evento é obrigatória!")]
        public string? NomeEvento { get; set; }

        // Descrição
        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "A Descrição é obrigatória!")]

        public string? Descricao { get; set; }

        //--------------------------------------------------------------------------------


        // FK do IdTipoEvento
        public Guid IdTipoEvento { get; set; }
        [ForeignKey("IdTipoEvento")]
        public TiposEventos? TipoEvento { get; set; }

        // FK do IdInstituicao
        public Guid? IdInstituicoes { get; set; }
        [ForeignKey("IdInstituicoes")]
        public Instituicoes? Instituicao { get; set; }
    }
}
