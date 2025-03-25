using EventPlus_.Domains;
using Events_PLUS.Domains;

namespace Events_PLUS.Interfaces
{
    public interface ITipoEventoRepository
    {
        List<TiposEventos> Listar();
        void Cadastrar(TiposEventos novoTipoEvento);
        
        void Atualizar(Guid id, TiposEventos tipoEvento);
        void Deletar(Guid id);

        TiposEventos BuscarPorId(Guid id);
    }
}