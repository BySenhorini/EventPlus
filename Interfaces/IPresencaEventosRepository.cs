namespace Events_PLUS.Interfaces
{
    public class IPresencaEventosRepository
    {
        public interface IPresencasEventosRepository
        {
            void Deletar(Guid id);

            List<IPresencaEventosRepository> Listar();

            IPresencaEventosRepository BuscarPorID(Guid id);

            void Atualizar(Guid id, IPresencaEventosRepository presencaEventos);

            List<IPresencaEventosRepository> ListarMinhas(Guid id);

            void Inscrever(IPresencaEventosRepository evento);
        }
    }
}
