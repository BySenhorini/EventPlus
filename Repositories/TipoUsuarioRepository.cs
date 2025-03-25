using EventPlus_.Context;
using EventPlus_.Interfaces;
using Events_PLUS.Domains;

namespace EventPlus_.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        private readonly Eventos_Context _Context;
        public void Atualizar(Guid id, TiposUsuarios tipoUsuario)
        {
            try
            {
                TiposUsuarios tipoUsuarioBuscado = _Context.TiposUsuarios.Find(id)!;
                if (tipoUsuarioBuscado != null)
                {
                    tipoUsuarioBuscado.TituloTipoUsuario = tipoUsuario.TituloTipoUsuario;
                }
                _Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public TiposUsuarios BuscarPorId(Guid id)
        {
            TiposUsuarios tipoUsuarioBuscado = _Context.TiposUsuarios.Find(id)!;
            return tipoUsuarioBuscado;
        }

        public void Cadastrar(TiposUsuarios novoTipoUsuario)
        {
            try
            {
                _Context.TiposUsuarios.Add(novoTipoUsuario);

                _Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Deletar(Guid id)
        {
            try
            {
                TiposUsuarios tipoUsuarioBuscado = _Context.TiposUsuarios.Find(id)!;
                if (tipoUsuarioBuscado != null)
                {
                    _Context.TiposUsuarios.Remove(tipoUsuarioBuscado);
                    _Context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<TiposUsuarios> Listar()
        {
            List<TiposUsuarios> listaTipoUsuario = _Context.TiposUsuarios.ToList();
            return listaTipoUsuario;
        }
    }
}