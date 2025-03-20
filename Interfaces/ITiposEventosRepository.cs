using Events_PLUS.Domains;

namespace Events_PLUS.Interfaces
{
        public interface ITiposEventosRepository
        {
            void Cadastrar(TiposEventos tipoEvento);

            List<TiposEventos> Listar();
            void Deletar(Guid id);

            void Atualizar(Guid id, TiposEventos tipoEvento);

            TiposEventos BuscarPorId(Guid id);
        }
    }
