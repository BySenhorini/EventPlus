﻿
using Microsoft.EntityFrameworkCore;
using EventPlus_.Domains;

namespace EventPlus_.Contexts
{
    public class Context : DbContext
    {
        public Context()
        {
        }
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<TiposUsuarios> TiposUsuarios { get; set; }

        public DbSet<Usuarios> Usuarios { get; set; }

        public DbSet<TiposEventos> TiposEventos { get; set; }
        public DbSet<Eventos> Eventos { get; set; }

        public DbSet<ComentariosEventos> ComentarioEvento { get; set; }

        public DbSet<Instituicoes> Instituicoes { get; set; }

        public DbSet<PresencasEventos> PresencasEventos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE43-S28\\SQLEXPRESS; Database=event; Integrated Security=True; TrustServerCertificate=true;");
            }
        }
    }
}