using Events_PLUS.Domains;

namespace Events_PLUS.Interfaces
{
    public interface IEventoRepository
    {
        void Cadastrar(Eventos novoEvento);

        void Deletar(Guid id);

        List<Eventos> Listar();

        List<Eventos> ListarPorID(Guid id);

        Eventos ProximosEventos();

        TiposEventos BuscarPorID(Guid id);

        void Atualizar(Guid id, Eventos evento);
    }
}