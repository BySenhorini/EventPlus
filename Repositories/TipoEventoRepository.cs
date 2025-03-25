using EventPlus_.Context;
using EventPlus_.Domains;
using Events_PLUS.Interfaces;

namespace EventPlus_.Repositories
{
    public class TipoEventoRepository : ITipoEventoRepository
    {
        private readonly Eventos_Context _context;

        public TipoEventoRepository(Eventos_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, TiposEventos tipoEvento)
        {
            try
            {
                TiposEventos tipoEventoBuscado = _context.TiposEventos.Find(id)!;

                if (tipoEventoBuscado != null)
                {
                    tipoEventoBuscado.TituloTipoEvento = tipoEvento.TituloTipoEvento;
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
                TiposEventos tipoEventoBuscado = _context.TiposEventos.Find(id)!;
                return tipoEventoBuscado;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(TiposEventos novoTipoEvento)
        {
            try
            {
                _context.TiposEventos.Add(novoTipoEvento);

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
                TiposEventos tipoEventoBuscado = _context.TiposEventos.Find(id)!;

                if (tipoEventoBuscado != null)
                {
                    _context.TiposEventos.Remove(tipoEventoBuscado);
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
            try
            {
                List<TiposEventos> listaDeEventos = _context.TiposEventos.ToList();
                return listaDeEventos;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}