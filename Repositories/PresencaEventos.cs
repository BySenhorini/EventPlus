using EventPlus_.Context;
using EventPlus_.Domains;
using Events_PLUS.Interfaces;

namespace EventPlus_.Repositories
{
    public class PresencasRepository : IPresencasRepository
    {
        private readonly Eventos_Context _context;

        public PresencasRepository(Eventos_Context context)
        {
            _context = context;
        }

        public void Atualizar(Guid id, PresencasEventos presenca)
        {
            try
            {
                PresencasEventos presencaBuscado = _context.PresencasEventos.Find(id)!;

                if (presencaBuscado != null)
                {
                    presencaBuscado.Situacao = presenca.Situacao;
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PresencasEventos BuscarPorId(Guid id)
        {
            try
            {
                PresencasEventos presencaBuscado = _context.PresencasEventos.Find(id)!;
                return presencaBuscado;
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
                PresencasEventos presencaBuscado = _context.PresencasEventos.Find(id)!;

                if (presencaBuscado != null)
                {
                    _context.PresencasEventos.Remove(presencaBuscado);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Inscrever(PresencasEventos inscreverPresenca)
        {
            try
            {
                _context.PresencasEventos.Add(inscreverPresenca);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PresencasEventos> Listar()
        {
            try
            {
                List<PresencasEventos> listaPresenca = _context.PresencasEventos.ToList();
                return listaPresenca;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PresencasEventos> ListarMinhasPresencas(Guid id)
        {
            try
            {
                List<PresencasEventos> listaPresenca = _context.PresencasEventos.Where(p => p.UsuarioID == id).ToList();
                return listaPresenca;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}