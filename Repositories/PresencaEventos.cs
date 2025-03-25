using EventPlus_.Contexts;
using EventPlus_.Domains;
using EventPlus_.Interfaces;

namespace EventPlus_.Repositories
{
    public class PresencasEventosRepository : IPresencasEventosRepository
    {
        private readonly Context _context;

        public PresencasEventosRepository(Context context)
        {
            _context = context;
        }
        public void Atualizar(Guid id, PresencasEventos presencaEvento)
        {
            try
            {
                PresencasEventos presencaEventoBuscado = _context.PresencasEventos.Find(id)!;

                if (presencaEventoBuscado != null)
                {
                    if (presencaEventoBuscado.Situacao)
                    {
                        presencaEventoBuscado.Situacao = false;
                    }
                    else
                    {
                        presencaEventoBuscado.Situacao = true;
                    }

                }

                _context.PresencasEventos.Update(presencaEventoBuscado!);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PresencasEventos BuscarPorId(Guid id)
        {
            try
            {
                return _context.PresencasEventos
                    .Select(p => new PresencasEventos
                    {
                        IdPresencaEvento = p.IdPresencaEvento,
                        Situacao = p.Situacao,

                        Evento = new Eventos
                        {
                            IdEvento = p.IdEvento!,
                            DataEvento = p.Evento!.DataEvento,
                            NomeEvento = p.Evento.NomeEvento,
                            Descricao = p.Evento.Descricao,

                            Instituicao = new Instituicoes
                            {
                                IdInstituicoes = p.Evento.Instituicao!.IdInstituicoes,
                                NomeFantasia = p.Evento.Instituicao!.NomeFantasia
                            }
                        }

                    }).FirstOrDefault(p => p.IdPresencaEvento == id)!;
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
                PresencasEventos presencaEventoBuscado = _context.PresencasEventos.Find(id)!;

                if (presencaEventoBuscado != null)
                {
                    _context.PresencasEventos.Remove(presencaEventoBuscado);
                }

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Inscrever(PresencasEventos inscricao)
        {
            try
            {
                inscricao.IdPresencaEvento = Guid.NewGuid();

                _context.PresencasEventos.Add(inscricao);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PresencasEventos> Listar()
        {

            try
            {
                return _context.PresencasEventos
                    .Select(p => new PresencasEventos
                    {
                        IdPresencaEvento = p.IdPresencaEvento,
                        Situacao = p.Situacao,

                        Evento = new Eventos
                        {
                            IdEvento = p.IdEvento,
                            DataEvento = p.Evento!.DataEvento,
                            NomeEvento = p.Evento.NomeEvento,
                            Descricao = p.Evento.Descricao,

                            Instituicao = new Instituicoes
                            {
                                IdInstituicoes = p.Evento.Instituicao!.IdInstituicoes,
                                NomeFantasia = p.Evento.Instituicao!.NomeFantasia
                            }
                        }

                    }).ToList();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<PresencasEventos> ListarMinhas(Guid id)
        {
            return _context.PresencasEventos
                .Select(p => new PresencasEventos
                {
                    IdPresencaEvento = p.IdPresencaEvento,
                    Situacao = p.Situacao,
                    IdUsuario = p.IdUsuario,
                    IdEvento = p.IdEvento,

                    Evento = new Eventos
                    {
                        IdEvento = p.IdEvento,
                        DataEvento = p.Evento!.DataEvento,
                        NomeEvento = p.Evento!.NomeEvento,
                        Descricao = p.Evento!.Descricao,

                        Instituicao = new Instituicoes
                        {
                            IdInstituicoes = p.Evento!.IdInstituicoes,
                        }
                    }
                })
                .Where(p => p.IdUsuario == id)
                .ToList();
        }
    }
}