using EventPlus_.Context;
using EventPlus_.Utils;
using Events_PLUS.Domains;
using Events_PLUS_.Interfaces;

namespace Events_PLUS_.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Eventos_Context _Context;
        public UsuarioRepository(Eventos_Context context)
        {
            _Context = context;
        }

        public Usuarios BuscarPorEmailESenha(string email, string senha)
        {
            try
            {
                Usuarios usuarioBuscado = _Context.Usuarios.FirstOrDefault(u => u.Email == email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(senha, usuarioBuscado.Senhas!);

                    if (confere)
                    {
                        return usuarioBuscado;
                    }
                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Usuarios BuscarPorId(Guid id)
        {
            try
            {
                Usuarios usuarioBuscado = _Context.Usuarios.Find(id)!;

                if (usuarioBuscado != null)
                {
                    return usuarioBuscado;
                }
                return null!;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Cadastrar(Usuarios novoUsuario)
        {
            try
            {

                _Context.Usuarios.Add(novoUsuario);

                _Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
