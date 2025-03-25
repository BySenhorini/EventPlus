
using Events_PLUS.Domains;

namespace EventPlus_.Interfaces
{
    public interface ITipoUsuarioRepository
    {
        void Cadastrar(TiposUsuarios tipoUsuario);

        List<TiposUsuarios> Listar();

        void Atualizar(Guid id, TiposUsuarios tipoUsuario);
        void Deletar(Guid id);

        TiposUsuarios BuscarPorId(Guid id);

    }
}