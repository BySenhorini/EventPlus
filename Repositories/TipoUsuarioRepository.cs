using Events_PLUS.Context;
using Events_PLUS.Domains;
using Events_PLUS.Interfaces;

namespace projeto_event_plus.Repositories
{
    public class TiposUsuariosRepository : ITiposUsuariosRepository
    {
        private readonly Events_PLUS_Context _context;
        public TiposUsuariosRepository(Events_PLUS_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TiposUsuarios tiposUsuarios)
        {
            try
            {
                TiposUsuarios tiposUsuariosBuscado = _context.TiposUsuarios.Find(id)!;

                if (tiposUsuariosBuscado != null)
                {
                    tiposUsuariosBuscado.TituloTipoUsuario = tiposUsuarios.TituloTipoUsuario;
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public TiposUsuarios BuscarPorId(Guid id)
        {
            try
            {
                TiposUsuarios tiposUsuariosBuscado = _context.TiposUsuarios.Find(id)!;
                return tiposUsuariosBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(TiposUsuarios tiposUsuarios)
        {
            try
            {
                _context.TiposUsuarios.Add(tiposUsuarios);
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
                TiposUsuarios tiposUsuariosBuscado = _context.TiposUsuarios.Find(id)!;

                if (tiposUsuariosBuscado != null)
                {
                    _context.TiposUsuarios.Remove(tiposUsuariosBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TiposUsuarios> Listar()
        {
            return _context.TiposUsuarios.ToList();
        }
    }
}