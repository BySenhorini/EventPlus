using EventPlus_.Contexts;
using EventPlus_.Domains;
using EventPlus_.Interfaces;

namespace EventPlus_.Repositories
{
    public class ComentariosEventosRepository : IComentariosEventosRepository
    {

        private readonly Context _context;

        public ComentariosEventosRepository(Context context)
        {
            _context = context;
        }
        public ComentariosEventos BuscarPorIdUsuario(Guid idUsuario, Guid idEvento)
        {
            try
            {
                return _context.ComentarioEvento
                    .Select(c => new ComentariosEventos
                    {
                        IdComentarioEvento = c.IdComentarioEvento,
                        Descricao = c.Descricao,
                        Exibe = c.Exibe,
                        IdUsuario = c.IdUsuario,
                        IdEvento = c.IdEvento,

                        Usuario = new Usuarios
                        {
                            NomeUsuario = c.Usuario!.NomeUsuario
                        },

                        Evento = new Eventos
                        {
                            NomeEvento = c.Evento!.NomeEvento,
                        }

                    }).FirstOrDefault(c => c.IdUsuario == idUsuario && c.IdEvento == idEvento)!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(ComentariosEventos comentarioEvento)
        {
            try
            {
                comentarioEvento.IdComentarioEvento = Guid.NewGuid();

                _context.ComentarioEvento.Add(comentarioEvento);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                ComentariosEventos comentarioEventoBuscado = _context.ComentarioEvento.Find(id)!;

                if (comentarioEventoBuscado != null)
                {
                    _context.ComentarioEvento.Remove(comentarioEventoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<ComentariosEventos> Listar(Guid id)
        {
            try
            {
                return _context.ComentarioEvento
                    .Select(c => new ComentariosEventos
                    {
                        IdComentarioEvento = c.IdComentarioEvento,
                        Descricao = c.Descricao,
                        Exibe = c.Exibe,
                        IdUsuario = c.IdUsuario,
                        IdEvento = c.IdEvento,

                        Usuario = new Usuarios
                        {
                            NomeUsuario = c.Usuario!.NomeUsuario
                        },

                        Evento = new Eventos
                        {
                            NomeEvento = c.Evento!.NomeEvento,
                        }

                    }).Where(c => c.IdEvento == id).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<ComentariosEventos> ListarSomenteExibe(Guid id)
        {
            try
            {
                return _context.ComentarioEvento
                    .Select(c => new ComentariosEventos
                    {
                        IdComentarioEvento = c.IdComentarioEvento,
                        Descricao = c.Descricao,
                        Exibe = c.Exibe,
                        IdUsuario = c.IdUsuario,
                        IdEvento = c.IdEvento,

                        Usuario = new Usuarios
                        {
                            NomeUsuario = c.Usuario!.NomeUsuario
                        },

                        Evento = new Eventos
                        {
                            NomeEvento = c.Evento!.NomeEvento,
                        }

                    }).Where(c => c.Exibe == true && c.IdEvento == id).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}