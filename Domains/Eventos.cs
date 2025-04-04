﻿using EventPlus_.Domains;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventPlus_.Domains
{
    [Table("Eventos")]
    public class Eventos
    {
        [Key]
        public Guid IdEvento { get; set; }

        [Column(TypeName = "DATE")]
        [Required(ErrorMessage = "A data do evento é obrigatória!")]
        public DateTime DataEvento { get; set; }

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do evento obrigatório!")]
        public string? NomeEvento { get; set; }

        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descrição do evento obrigatório!")]
        public string? Descricao { get; set; }

        //ref.tabela TiposEventos
        public Guid IdTipoEvento { get; set; }

        [ForeignKey("IdTipoEvento")]
        public TiposEventos? TiposEvento { get; set; }

        //ref.tabela Instituicoes
        public Guid IdInstituicoes { get; set; }

        [ForeignKey("IdInstituicao")]
        public Instituicoes? Instituicao { get; set; }

        public PresencasEventos? PresencasEventos { get; set; }
    }
}