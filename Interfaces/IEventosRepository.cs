using EventPlus_.Domains;


namespace EventPlus_.Interfaces
{
    public interface IEventosRepository
    {
        void Cadastrar(Eventos evento);
        void Deletar(Guid id);
        List<Eventos> Listar();
        List<Eventos> ListarPorId(Guid id);
        List<Eventos> ProximosEventos();
        Eventos BuscarPorId(Guid id);
        void Atualizar(Guid id, Eventos evento);
        List<Eventos> ListarProximosEventos(Guid id);
    }
}