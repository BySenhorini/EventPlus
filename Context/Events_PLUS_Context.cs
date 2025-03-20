using Events_PLUS.Domains;
using Microsoft.EntityFrameworkCore;

namespace projeto_event_plus.Contexts
{
    public class Event_Context : DbContext
    {
        public Event_Context() { }
        public Event_Context(DbContextOptions<Event_Context> options) : base(options) { }
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<TiposUsuarios> TiposUsuarios { get; set; }
        public DbSet<TiposEventos> TiposEventos { get; set; }
        public DbSet<PresencasEventos> PresencasEventos { get; set; }
        public DbSet<Instituicoes> Instituicoes { get; set; }
        public DbSet<Eventos> Eventos { get; set; }
        public DbSet<ComentarioEvento> ComentarioEvento { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NOTE43-S28\\SQLEXPRESS; Database=projeto_event_plus; User Id=sa; Pwd = Senai@134; TrustServerCertificate=true;");
            }
        }

    }
}
