
using Projeto_Event_Plus.Utils;
using Events_PLUS.Interfaces;
using Events_PLUS.Context;
using Events_PLUS.Domains;

namespace Projeto_Event_Plus.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly Events_PLUS_Context _context;

        public UsuarioRepository(Events_PLUS_Context context)
        {
            _context = context;
        }

        public Usuarios BuscarPorEmailESenha(string Email, string Senha)
        {
            try
            {
                Usuarios usuarioBuscado = _context.Usuarios.FirstOrDefault(u => u.Email == Email)!;

                if (usuarioBuscado != null)
                {
                    bool confere = Criptografia.CompararHash(Senha, usuarioBuscado.Senha!);

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

        public Usuarios BuscarPorID(Guid id)
        {
            try
            {
                Usuarios usuarioBuscado = _context.Usuarios.Find(id)!;

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
                novoUsuario.Senha = Criptografia.GerarHash(novoUsuario.Senha!);

                _context.Usuarios.Add(novoUsuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}