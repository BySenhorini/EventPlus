using EventPlus_.Context;
using EventPlus_.Domains;
using Events_PLUS.Domains;
using Microsoft.EntityFrameworkCore;

namespace EventsPlus_.Context
{

    public class Events_PLUS_Context : DbContext
    {
        public Events_PLUS_Context()
        {
        }

        public Events_PLUS_Context(DbContextOptions<Eventos_Context> options) : base(options)
        {
        }

        public DbSet<ComentarioEvento> ComentarioEvento { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<Instituicoes> Instituicoes { get; set; }
        public DbSet<PresencasEventos> PresencasEventos { get; set; }
        public DbSet<TiposEventos> TiposEventos { get; set; }
        public DbSet<TiposUsuarios> TiposUsuarios { get; set; }
        public DbSet<Usuarios> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server = DESKTOP-0HO9ARA\\SQLEXPRESS; Database = EventPlus; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }
        }

    }
}