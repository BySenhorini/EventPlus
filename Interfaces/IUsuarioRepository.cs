using Events_PLUS.Domains;

namespace Events_PLUS_.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuarios novoUsuario);

        Usuarios BuscarPorId(Guid id);

        Usuarios BuscarPorEmailESenha(string email, string senha);

    }
}