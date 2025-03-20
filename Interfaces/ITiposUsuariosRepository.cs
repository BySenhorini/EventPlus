using Events_PLUS.Domains;

namespace Events_PLUS.Interfaces
{
        public interface ITiposUsuariosRepository
        {
            void Cadastrar(TiposUsuarios novoTipoUsuario);
            void Deletar(Guid id);

            List<TiposUsuarios> Listar();

            TiposUsuarios BuscarPorID(Guid id);

            void Atualizar(Guid id, TiposUsuarios tipoUsuario);
        }
    }
