using EventPlus_.Domains;

namespace Events_PLUS.Interfaces
{
    public interface IPresencasRepository
    {
        void Deletar(Guid id);

        PresencasEventos BuscarPorId(Guid id);

        void Atualizar(Guid id, PresencasEventos presenca);

        List<PresencasEventos> Listar();

        List<PresencasEventos> ListarMinhasPresencas(Guid id);

        void Inscrever(PresencasEventos inscreverPresenca);

    }
}