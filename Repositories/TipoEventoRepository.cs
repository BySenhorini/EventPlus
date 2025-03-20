using Events_PLUS.Context;
using Events_PLUS.Domains;
using Events_PLUS.Interfaces;


namespace projeto_event_plus.Repositories
{
    public class TiposEventosRepository : ITiposEventosRepository
    {
        private readonly Events_PLUS_Context _context;
        public TiposEventosRepository(Events_PLUS_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TiposEventos tiposEventos)
        {
            try
            {
                TiposEventos tiposEventosBuscado = _context.TiposEventos.Find(id)!;

                if (tiposEventosBuscado != null)
                {
                    tiposEventosBuscado.TituloTipoEvento = tiposEventos.TituloTipoEvento;
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }


        public TiposEventos BuscarPorId(Guid id)
        {
            try
            {
                TiposEventos tiposEventosBuscado = _context.TiposEventos.Find(id)!;
                return tiposEventosBuscado;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Cadastrar(TiposEventos tiposEventos)
        {
            try
            {
                _context.TiposEventos.Add(tiposEventos);
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
                TiposEventos tiposEventos = _context.TiposEventos.Find(id)!;

                if (tiposEventos != null)
                {
                    _context.TiposEventos.Remove(tiposEventos);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TiposEventos> Listar()
        {
            return _context.TiposEventos.ToList();
        }
    }
}
