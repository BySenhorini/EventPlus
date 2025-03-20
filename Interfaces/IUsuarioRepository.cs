using Events_PLUS.Domains;

namespace Events_PLUS.Interfaces
{
        public interface IUsuarioRepository
        {
            void Cadastrar(Usuarios novoUsuario);

            Usuarios BuscarPorID(Guid id);

            Usuarios BuscarPorEmailESenha(string Email, string Senha);
        }
    }
