using EventPlus_.Domains;

namespace EventPlus_.Interfaces
{
    public interface IComentariosEventosRepository
    {
        void Cadastrar(ComentariosEventos comentarioEvento);
        void Deletar(Guid id);
        List<ComentariosEventos> Listar(Guid id);
        ComentariosEventos BuscarPorIdUsuario(Guid idUsuario, Guid idEvento);
    }
}