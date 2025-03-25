﻿//using Events_PLUS.Domains;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlus_.Domains
{
    [Table("Eventos")]
    public class Eventos
    {
        [Key]
        public Guid EventosID { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "Nome do evento é obrigatório!")]
        public string? NomeEvento { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descrição do evento obrigatória!")]
        public string? Descricao { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data do evento é obrigatória!")]
        public DateTime DataEvento { get; set; }


        [Required(ErrorMessage = "O evento é obrigatório")]
        public Guid TiposEventosID { get; set; }

        [ForeignKey("TipoEventoID")]
        public TiposEventos? TiposEventos { get; set; }


        [Required(ErrorMessage = "A instituição é obrigatório")]
        public Guid InstituicoesID { get; set; }

        [ForeignKey("InstituicaoID")]
        public Instituicoes? Instituicoes { get; set; }


        public PresencasEventos? Presenca { get; set; }


    }
}