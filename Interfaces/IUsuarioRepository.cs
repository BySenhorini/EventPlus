using EventPlus_.Domains;

namespace EventPlus_.Interfaces
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuarios usuario);

        Usuarios BuscarPorId(Guid id);

        Usuarios BuscarPorEmailESenha(string email, string senha);
    }
}